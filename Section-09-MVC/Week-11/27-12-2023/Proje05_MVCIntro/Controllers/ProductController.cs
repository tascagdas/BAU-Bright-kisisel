using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Proje05_MVCIntro.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult Index(){
            return View();
        }
        public IActionResult AddProduct(){
            return View();
        }
    }
}