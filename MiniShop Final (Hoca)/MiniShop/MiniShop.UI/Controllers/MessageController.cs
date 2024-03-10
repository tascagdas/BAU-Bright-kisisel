using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MiniShop.Business.Abstract;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.ViewModels;

namespace MiniShop.UI.Controllers
{
    [Authorize]
    public class MessageController : Controller
    {
        private readonly IMessageService _messageManager;
        private readonly UserManager<User> _userManager;
        private readonly INotyfService _notyfManager;

        public MessageController(IMessageService messageManager, UserManager<User> userManager, INotyfService notyfManager)
        {
            _messageManager = messageManager;
            _userManager = userManager;
            _notyfManager = notyfManager;
        }

        public async Task<IActionResult> Index()
        {

            var userId = _userManager.GetUserId(User);
            var response = await _messageManager.GetAllReceivedMessageAsync(userId);
            var messages = response.Data ?? new List<MessageViewModel>();
            return View(messages);
        }

        public async Task<IActionResult> NewMessage()
        {
            var users = await _userManager.Users.ToListAsync();
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
            //Kime
            var toUser = await _userManager.FindByIdAsync(model.ToId);
            model.ToName = toUser.UserName;
            //Kimden
            var fromUser = await _userManager.FindByIdAsync(_userManager.GetUserId(User));
            model.FromId = fromUser.Id;
            model.FromName = fromUser.UserName;
            //Yanıtlanıyor ise
            if (model.ReplyText != null)
            {
                model.Text = model.ReplyText;

            }
            var result = await _messageManager.CreateAsync(model);
            if (result.IsSucceeded)
                _notyfManager.Success("Mesaj başarıyla gönderildi.");
            else
                _notyfManager.Error("Mesaj gönderilemedi.");
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
}
