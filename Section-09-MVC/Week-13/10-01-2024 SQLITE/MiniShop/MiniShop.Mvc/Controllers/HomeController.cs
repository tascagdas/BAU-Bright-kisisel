using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Mvc.Models;

namespace MiniShop.Mvc.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

}

