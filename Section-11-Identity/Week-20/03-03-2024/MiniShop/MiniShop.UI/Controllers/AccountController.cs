using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MiniShop.Business.Abstract;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.ViewModels;
using MiniShop.Shared.ViewModels.IdentityModels;
using MiniShop.UI.EmailServices.Abstract;

namespace MiniShop.UI.Controllers;

public class AccountController : Controller
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly IOrderService _orderManager;
    private readonly IEmailSender _emailSender;
    private readonly IShoppingCartService _shoppingCartManager;
    private readonly INotyfService _notyfService;
    public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IOrderService orderManager, IEmailSender emailSender, IShoppingCartService shoppingCartManager, INotyfService notyfService)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _orderManager = orderManager;
        _emailSender = emailSender;
        _shoppingCartManager = shoppingCartManager;
        _notyfService = notyfService;
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
    {
        if (ModelState.IsValid)
        {
            User user = new User
            {
                UserName = registerViewModel.UserName,
                Email = registerViewModel.Email,
                FirstName = registerViewModel.FirstName,
                LastName = registerViewModel.LastName
                ,EmailConfirmed = true
            };
            var result = await _userManager.CreateAsync(user,registerViewModel.Password);
            if (result.Succeeded)
            {
                //Mail gonderme islemi basliyor
                
                //Token olusturma
                var tokenCode = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var backUrl = Url.Action("ConfirmEmail", "Account", new
                {
                    userId = user.Id,
                    token = tokenCode
                });
                
                
                
                
                
                //Gecici olarak devre disi birakildi.
                
                
                
                
                
                //
                // //Mail gonderme kismi
                // await _emailSender.SendEmailAsync(user.Email, "MiniShopApp uyelik onayi",
                //     $"<p>MinishopApp uygulamasina uyeliginizi onaylamak icin asagidaki linke tiklayiniz.</p><a href='https://localhost:59079{backUrl}'>Onay Linki</a>");
                //
               
                
                await _shoppingCartManager.InitializeShoppingCartAsync(user.Id);

                
                _notyfService.Success("Uyeliginiz basariyla olusturulmustur. Mailinizi kontrol ederek mailinizi onaylayabilirsiniz.",10);
                

                return Redirect("~/");
            }
        }
        return View(registerViewModel);
    }

    [HttpGet]
    public IActionResult Login(string returnUrl=null)
    {
        if (returnUrl!=null)
        {
            TempData["ReturnUrl"] = returnUrl;
        }
        return View();
    }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if(ModelState.IsValid)
            {
                User user = await _userManager.FindByNameAsync(loginViewModel.UserName);
                if (user != null)
                {
                    //Olası daha önceden kalmış olan cookieyi temizliyoruz.
                    await _signInManager.SignOutAsync();
                    //Mail onayını kontrol ediyoruz.
                    var isConfirmed = await _userManager.IsEmailConfirmedAsync(user);
                    if (!isConfirmed)
                    {
                        _notyfService.Warning("Hesabınız onaylı değildir. Mailinize gelen onay linkini tıklayarak, onaylayabilirsiniz.");
                        return View(loginViewModel);
                    }
                    //Login olmayı deniyoruz.
                    var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, loginViewModel.RememberMe, true);
                    if (result.Succeeded)
                    {
                        await _userManager.ResetAccessFailedCountAsync(user);
                        await _userManager.SetLockoutEndDateAsync(user, null);

                        var returnUrl = TempData["ReturnUrl"]?.ToString();
                        _notyfService.Information("Giriş başarılı. Hoş geldiniz.");
                        if (!String.IsNullOrEmpty(returnUrl))
                        {
                            return Redirect(returnUrl);
                        }
                        return RedirectToAction("Index", "Home");
                    }
                    else if (result.IsLockedOut)    
                    {

                        var lockoutEndDate = await _userManager.GetLockoutEndDateAsync(user);
                        if (lockoutEndDate>DateTime.Now)
                        {
                            
                            _notyfService.Information($"Hesabınız {lockoutEndDate.Value.ToString("f")} zamanına kadar kilitlendi.");
                        }
                        else
                        {
                            var timeLeft = (lockoutEndDate.Value - DateTime.Now).Seconds;
                            _notyfService.Information($"Hesabınız kilitli. Lütfen {timeLeft} sn sonra yeniden deneyiniz.");
                        }

                        return View(loginViewModel);
                    }
                    else
                    {
                        var attempCount = _signInManager.Options.Lockout.MaxFailedAccessAttempts;
                        var failedAttempCount = await _userManager.GetAccessFailedCountAsync(user);
                        var lockountEndDate= await _userManager.GetLockoutEndDateAsync(user);   
 
                            var accessFailedCount = attempCount - failedAttempCount;
                            _notyfService.Information($"Kalan deneme hakkınız: {accessFailedCount}");
                        
                    }
                }

            }
            return View(loginViewModel);
        }
    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        TempData["ReturnUrl"] = null;
        _notyfService.Information("Basariyla cikis yapilmistir.");
        return Redirect("~/");
    }

    public async Task<IActionResult> AccessDenied()
    {
        return View();
    }
    [HttpGet]
    public async Task<IActionResult> Profile()
    {
        var userId = _userManager.GetUserId(User);
        var orders = await _orderManager.GetOrdersAsync(userId);
        var user = await _userManager.FindByIdAsync(userId);

        //simdilik view e bir order listesi yolluyoruz sonraki asamalarda bu liste ile birlikte baska bilgilerde yollanicak.

        UserProfileViewModel userProfileViewModel = new UserProfileViewModel
        {
            User = new UserViewModel
            {
                Id = userId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Address = user.Address,
                City = user.City,
                Gender = user.Gender,
                DateOfBirth = user.DateOfBirth
            },
            Orders = orders
        };
        
        return View(userProfileViewModel);
    }

    [HttpPost]
    public async Task<IActionResult> Profile(UserProfileViewModel userProfileViewModel)
    {
        var userId = _userManager.GetUserId(User);
        var user = await _userManager.FindByIdAsync(userId);
        if (ModelState.IsValid)
        {
            user.UserName = userProfileViewModel.User.UserName;
            user.FirstName = userProfileViewModel.User.FirstName;
            user.LastName = userProfileViewModel.User.LastName;
            user.Email = userProfileViewModel.User.Email;
            user.City = userProfileViewModel.User.City;
            user.PhoneNumber = userProfileViewModel.User.PhoneNumber;
            user.DateOfBirth = userProfileViewModel.User.DateOfBirth;
            user.Gender = userProfileViewModel.User.Gender;
            
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                await _userManager.UpdateSecurityStampAsync(user);
                await _signInManager.SignOutAsync();
                await _signInManager.SignInAsync(user, false);
                _notyfService.Success("profiliniz basariyla guncellenmistir.");
                return Redirect("~/");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("",error.Description);
            }
            
        }
        userProfileViewModel.Orders=await _orderManager.GetOrdersAsync(userId);
        return View(userProfileViewModel);
    }

    public async Task<IActionResult> ChangePassword()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> ChangePassword(ChangePasswordViewModel changePasswordViewModel)
    {
        if (ModelState.IsValid)
        {
            var user =await _userManager.FindByIdAsync(_userManager.GetUserId(User));
            var isVerified = await _userManager.CheckPasswordAsync(user, changePasswordViewModel.OldPassword);
            if (isVerified)
            {
                var result = await _userManager.ChangePasswordAsync(user, changePasswordViewModel.OldPassword,
                    changePasswordViewModel.NewPassword);
                if (result.Succeeded)
                {
                    var updateSecurityStampResult = await _userManager.UpdateSecurityStampAsync(user);
                    await _signInManager.SignOutAsync();
                    await _signInManager.PasswordSignInAsync(user, changePasswordViewModel.NewPassword, false, false);
                    _notyfService.Success("sifreniz basariyla degistirilmistir.");
                    return RedirectToAction("Profile");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(changePasswordViewModel);
            }

            _notyfService.Warning("gecerli sifreniz hatali.");
            return View(changePasswordViewModel);
        }

        return View(changePasswordViewModel);
    }

    public async Task<IActionResult> ConfirmEmail(string userId,string token)
    {
        if (userId==null||token==null)
        {
            _notyfService.Warning("bilgilerde sorun var yonetici ile gorusunuz.");
            return View();
        }

        var user = await _userManager.FindByIdAsync(userId);
        if (user==null)
        {
            _notyfService.Warning("Kullanici bilgilerinize ulasilamadi.");
            return View();
        }

        var result = await _userManager.ConfirmEmailAsync(user, token);
        if (result.Succeeded)
        {
            //buraya kadar gelen user artik onayli olacagi icin shopping cartini olusturabiliriz.
            await _shoppingCartManager.InitializeShoppingCartAsync(userId);
            _notyfService.Information("hesabiniz basariyla onaylanmistir.");
            return RedirectToAction("Login");
        }
        _notyfService.Error("Hesabiniz onaylanirken bir sorun olustu daha sonra tekrar deneyiniz.");
        return View();
    }

    public IActionResult ForgotPassword()
    {
        
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> ForgotPassword(string email)
    {
        if (email==null)
        {
            ModelState.AddModelError("","email adresinizi yaziniz.");
            return View();
        }

        var user = await _userManager.FindByEmailAsync(email);
        if (user==null)
        {
            ModelState.AddModelError("","email adresi bulunamadi.");
            return View();
        }

        var tokenCode = await _userManager.GeneratePasswordResetTokenAsync(user);
        var backUrl = Url.Action("ResetPassword", "Account", new
        {
            userId = user.Id,
            tokenCode = tokenCode
        });
        var subject = "MiniShopApp Sifre Sifirlama";
        var htmlMessage = $"<h1>MiniShop sifre sifirlama islemi</h1>" +
                          $"<p>" +
                          $"Lutfen sifrenizi sfirlamak icin asagidaki linke tiklayiniz." +
                          $"</p>" +
                          $"<a href='https://localhost:59079{backUrl}'>" +
                          $"Sifre sifirla" +
                          $"</a>";
        await _emailSender.SendEmailAsync(email, subject, htmlMessage);
        return RedirectToAction("Login");
    }

    public async Task<IActionResult> ResetPassword(string userId, string tokenCode)
    {
        if (userId==null||tokenCode==null)
        {
            ModelState.AddModelError("","Bir sorun olustu.");
            return View();
        }

        var user = await _userManager.FindByIdAsync(userId);
        if (user==null)
        {
            
            ModelState.AddModelError("","kullanici bulunamadi.");
            return View();
        }

        ResetPasswordViewModel resetPasswordViewModel = new ResetPasswordViewModel
        {
            UserId = userId,
            TokenCode = tokenCode
        };
        return View(resetPasswordViewModel);
    }

    [HttpPost]
    public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordViewModel)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        var user = await _userManager.FindByIdAsync(resetPasswordViewModel.UserId);
        if (user==null)
        {
            ModelState.AddModelError("","Boyle kullanici bulunamadi");
            return View();
        }

        var result =
            await _userManager.ResetPasswordAsync(user, resetPasswordViewModel.TokenCode,
                resetPasswordViewModel.Password);
        if (result.Succeeded)
        {
            return RedirectToAction("Login");
        }

        foreach (var error in result.Errors)
        {
            ModelState.AddModelError("",error.Description);
        }

        return View(resetPasswordViewModel);
    }

}
