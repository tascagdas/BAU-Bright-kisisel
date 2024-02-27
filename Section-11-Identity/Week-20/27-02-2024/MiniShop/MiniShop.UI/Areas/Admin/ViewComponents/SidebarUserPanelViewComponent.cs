using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Entity.Concrete.Identity;

namespace MiniShop.UI.Areas.Admin.ViewComponents
{
    public class SidebarUserPanelViewComponent : ViewComponent
    {
        private readonly UserManager<User> _userManager;

        public SidebarUserPanelViewComponent(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = _userManager.GetUserAsync(UserClaimsPrincipal);
// username verisini çağırıldığı yerden metotun içine gönderip daha sonrada user bilgilerini çekip, isim soy isim yazdırılabilir. hangi yöntem daha hızlı bilmiyorum.
            ViewBag.firstName = user.Result.FirstName;
            ViewBag.lastName = user.Result.LastName;
            return View();
        }
    }
}