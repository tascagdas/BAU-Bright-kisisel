using Microsoft.AspNetCore.Mvc;

namespace MiniShop.UI.Areas.Admin.ViewComponents
{
    public class NavbarNotificationsViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}