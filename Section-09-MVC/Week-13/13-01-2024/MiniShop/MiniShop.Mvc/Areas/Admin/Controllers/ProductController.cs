using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MiniShop.Business.Abstract;
using MiniShop.Business.Concrete;

namespace MiniShop.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productManager;
        public ProductController(IProductService productManager)
        {
            _productManager = productManager;
        }

        public IActionResult Index()
        {
            var products = _productManager.GetAll();
            return View(products);
        }

    }
}