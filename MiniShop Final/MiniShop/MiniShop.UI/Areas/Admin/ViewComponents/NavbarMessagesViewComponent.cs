using Microsoft.AspNetCore.Mvc;

namespace MiniShop.UI.Areas.Admin.ViewComponents
{
    public class NavbarMessagesViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}