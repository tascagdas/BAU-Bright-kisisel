using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Core.ViewModels;
using MiniShop.Entity;
using MiniShop.Mvc.Models;
using System.Diagnostics;

namespace MiniShop.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productManager;

        public HomeController(IProductService productManager)
        {
            _productManager = productManager;
        }

        public IActionResult Index()
        {
            var products = _productManager.GetAll(true);
            return View(products);
        }

        public IActionResult GetById(int id)
        {
            ProductViewModel product = _productManager.GetById(id);
            return View(product);
        }

        
    }
}
