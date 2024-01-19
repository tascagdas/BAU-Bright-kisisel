using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;

namespace MiniShop.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryManager;
        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var response = await _categoryManager.GetAllCategoriesWithProductsAsync();
            return null;
        }
    }
}