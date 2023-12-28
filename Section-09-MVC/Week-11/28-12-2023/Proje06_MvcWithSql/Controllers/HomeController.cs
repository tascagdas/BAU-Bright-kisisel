using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Proje06_MvcWithSql.Dal;
using Proje06_MvcWithSql.Models;
using Proje06_MvcWithSql.ViewModels;

namespace Proje06_MvcWithSql.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        List<ProductViewModel> list = new List<ProductViewModel>{
            new ProductViewModel{Name="Iphone 13", Price=50000},
            new ProductViewModel{Name="Iphone 14", Price=51000},
            new ProductViewModel{Name="Iphone 15", Price=52000},
            new ProductViewModel{Name="Iphone 16", Price=53000},
            new ProductViewModel{Name="Iphone 17", Price=54000}
        };
        Db.OpenCn();
        return View(list);
    }

}
