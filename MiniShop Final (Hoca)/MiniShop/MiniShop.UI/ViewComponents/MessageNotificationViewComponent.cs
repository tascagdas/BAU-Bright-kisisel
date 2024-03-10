using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Entity.Concrete.Identity;

namespace MiniShop.UI.ViewComponents
{
    public class MessageNotificationViewComponent : ViewComponent
    {
        private readonly UserManager<User> _userManager;
        private readonly IMessageService _messageManager;

        public MessageNotificationViewComponent(UserManager<User> userManager, IMessageService messageManager)
        {
            _userManager = userManager;
            _messageManager = messageManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            var unreadMessageCount = await _messageManager.GetMessageCountAsync(userId);
            return View(unreadMessageCount.Data);
        }
    }
}
