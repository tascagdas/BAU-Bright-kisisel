using Microsoft.AspNetCore.Mvc;
using MiniShop.MVC.Areas.Admin.Models;

namespace MiniShop.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
