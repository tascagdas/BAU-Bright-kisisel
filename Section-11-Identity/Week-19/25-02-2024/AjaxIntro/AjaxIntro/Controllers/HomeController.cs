using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AjaxIntro.Models;

namespace AjaxIntro.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
}