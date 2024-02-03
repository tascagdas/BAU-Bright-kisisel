using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace MiniShop.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
