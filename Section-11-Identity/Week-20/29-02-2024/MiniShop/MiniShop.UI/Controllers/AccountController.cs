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
    public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IOrderService orderManager, IEmailSender emailSender, IShoppingCartService shoppingCartManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _orderManager = orderManager;
        _emailSender = emailSender;
        _shoppingCartManager = shoppingCartManager;
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
                await _emailSender.SendEmailAsync(user.Email, "MiniShopApp uyelik onayi",
                    $"<p>MinishopApp uygulamasina uyeliginizi onaylamak icin asagidaki linke tiklayiniz.</p><a href='https://localhost:59079{backUrl}'>Onay Linki</a>");
                
                
                
                // return RedirectToAction("Index","Home");
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
        if (!ModelState.IsValid)
        {
            return View(loginViewModel);
        }

        User user = await _userManager.FindByNameAsync(loginViewModel.UserName);
        if (user==null)
        {
            ModelState.AddModelError("","kullaniıcı bulunamadı");
            return View(loginViewModel);
        }

        var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);
        if (!result.Succeeded)
        {
            ModelState.AddModelError("","şifre hatalı");
            return View(loginViewModel);
        }

        var returnUrl = TempData["ReturnUrl"]?.ToString();
        if (!string.IsNullOrEmpty(returnUrl))
        {
            return Redirect(returnUrl);
        }
        return RedirectToAction("Index","Home");
        
    }

    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        TempData["ReturnUrl"] = null;
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
                    return RedirectToAction("Profile");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("",error.Description);
                }

                return View(changePasswordViewModel);
            }
            ModelState.AddModelError("","gecerli sifreniz hatalidir!");
            return View(changePasswordViewModel);
        }
        return View(changePasswordViewModel);
    }

    public async Task<IActionResult> ConfirmEmail(string userId,string token)
    {
        if (userId==null||token==null)
        {
            ModelState.AddModelError("","bilgilerde sorun var yonetici ile gorusunuz.");
            return View();
        }

        var user = await _userManager.FindByIdAsync(userId);
        if (user==null)
        {
            ModelState.AddModelError("","kullanici bilgilerinize ulasilamadi");
            return View();
        }

        var result = await _userManager.ConfirmEmailAsync(user, token);
        if (result.Succeeded)
        {
            //buraya kadar gelen user artik onayli olacagi icin shopping cartini olusturabiliriz.
            await _shoppingCartManager.InitializeShoppingCartAsync(userId);
            return View();
        }
        
        return View();
    }
}
