using Microsoft.AspNetCore.Mvc;

namespace MiniShop.Mvc.Areas.Admin.Controllers
{

    public class HomeController : Controller
    {
            [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
