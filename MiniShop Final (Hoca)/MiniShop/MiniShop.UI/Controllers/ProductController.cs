using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;

namespace MiniShop.UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productManager;
        private readonly ICategoryService _categoryManager;

        public ProductController(IProductService productManager, ICategoryService categoryManager)
        {
            _productManager = productManager;
            _categoryManager = categoryManager;
        }

        public async Task<IActionResult> Index(string categoryUrl = null)
        {
            var products =
                String.IsNullOrEmpty(categoryUrl) ?
                await _productManager.GetAllNonDeletedAsync() :
                await _productManager.GetProductsByCategoryUrlAsync(categoryUrl);

            var category = !String.IsNullOrEmpty(categoryUrl) ? await _categoryManager.GetByUrlAsync(categoryUrl) : null;

            ViewBag.CategoryName = category != null ? category.Data.Name : null;

            return View(products.Data);
        }

        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var product = await _productManager.GetByIdAsync(id);
            return View(product.Data);
        }
    }
}
