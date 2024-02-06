using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace MiniShop.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
