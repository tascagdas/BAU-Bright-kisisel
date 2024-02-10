using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.ViewModels.IdentityModels;

namespace MiniShop.UI.Controllers;

public class AccountController : Controller
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;

    public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
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
                // return RedirectToAction("Index","Home");
                return Redirect("~/");
            }
        }
        return View(registerViewModel);
    }

    [HttpGet]
    public IActionResult Login()
    {
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
        return RedirectToAction("Index","Home");
        
    }

    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        return Redirect("~/");
    }
}
