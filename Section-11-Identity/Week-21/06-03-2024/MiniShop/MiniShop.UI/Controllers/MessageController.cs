using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MiniShop.Business.Abstract;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.ViewModels;

namespace MiniShop.UI.Controllers;

[Authorize]
public class MessageController : Controller
{
    private readonly IMessageService _messageManager;
    private readonly UserManager<User> _userManager;
    private readonly INotyfService _notyfService;

    public MessageController(IMessageService messageManager, UserManager<User> userManager, INotyfService notyfService)
    {
        _messageManager = messageManager;
        _userManager = userManager;
        _notyfService = notyfService;
    }

    public async Task<IActionResult> Index()
    {
        
        var userId = _userManager.GetUserId(User);
        var response = await _messageManager.GetAllReceivedMessageAsync(userId);
        var messages = response.Data ?? new List<MessageViewModel>();
        
        return View(messages);
    }
[HttpGet]
    public async Task<IActionResult> NewMessage()
    {
        var users =await _userManager.Users.ToListAsync();
        List<SelectListItem> userSelectList = users.Select(x => new SelectListItem
        {
            Text = x.UserName,
            Value = x.Id
        }).ToList();
        MessageViewModel model = new MessageViewModel
        {
            UserList = userSelectList
        };
        return View(model);
    }
[HttpPost]
    public async Task<IActionResult> NewMessage(MessageViewModel model)
    {
        var toUser = await _userManager.FindByIdAsync(model.ToId);
        model.ToName = toUser.UserName;

        var fromUser = await _userManager.FindByIdAsync(_userManager.GetUserId(User));
        model.FromId = fromUser.Id;
        model.FromName = fromUser.UserName;
        var result=await _messageManager.CreateAsync(model);
        if (result.IsSucceeded)
        {
            _notyfService.Success("Mesaj Başarıyla Gönderildi.");
        }
        else
        {
            _notyfService.Error("Mesaj Gönderilemedi.");
        }
        
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> ReadMessage(int id)
    {
        var result = await _messageManager.GetByIdAsync(id);
        var message = result.Data;
        await _messageManager.MakeRead(id);
        return View(message);
    }
}