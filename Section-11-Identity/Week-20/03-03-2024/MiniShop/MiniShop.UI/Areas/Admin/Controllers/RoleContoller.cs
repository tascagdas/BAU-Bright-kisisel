using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniShop.Entity.Concrete.Identity;

namespace MiniShop.UI.Areas.Admin.Controllers;

[Authorize(Roles = "SuperAdmin")]
[Area("Admin")]
public class RoleController : Controller
{
    private readonly UserManager<User> _userManager;
    private readonly RoleManager<Role> _roleManager;
    private readonly INotyfService _notyfService;

    public RoleController(UserManager<User> userManager, RoleManager<Role> roleManager, INotyfService notyfService)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _notyfService = notyfService;
    }

    
    public async Task<IActionResult> Index() => View(await _roleManager.Roles.ToListAsync());

    
    public async Task<IActionResult> Create()
    {
        return View();
    }
    public async Task<IActionResult> Delete()
    {
        return View();
    }
    
    public async Task<IActionResult> AssignUsers()
    {
        return View();
    }
    
    
}