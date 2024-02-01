using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCFileUploadApp.Core;
using MVCFileUploadApp.Models;

namespace MVCFileUploadApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult UploadImage(IFormFile image)
    {
        if (image == null)
        {
            ViewBag.Message = "Reimde bir sorun var, lütfen tekrar deneyiniz.";
            return View("Index");
        }
        //localhost:5030/wwwroot/images/product5.png
        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", image.FileName);
        using (var stream = new FileStream(path, FileMode.Create))
        {
            image.CopyTo(stream);
        }

        ViewBag.Message = "Resim başarıyla yüklendi.";
        return View("Index");
    }
    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public IActionResult ResimYukle()
    {
        return View();
    }
    [HttpPost]
    public IActionResult ResimYukle(IFormFile image)
    {
        //Buraya resim yükleme için hazırlayacağımız metotı çağıracağız.
        var imageUrl = Uploader.UploadImage(image);
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

