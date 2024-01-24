using Microsoft.AspNetCore.Mvc;
using MiniShopUI.Areas.Admin.Models;

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
