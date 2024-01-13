using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Mvc.Models;

namespace MiniShop.Mvc.Controllers;

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

}