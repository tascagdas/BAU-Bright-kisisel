using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Shared.Helpers.Abstract;
using MiniShop.Shared.ResponseViewModels;
using MiniShop.Shared.ViewModels;
using MiniShop.UI.Helpers;

namespace MiniShop.UI.Areas.Admin.Controllers
{
    [Authorize(Roles = "SuperAdmin")]
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productManager;
        private readonly ICategoryService _categoryManager;
        private readonly IImageHelper _imageHelper;
        private readonly INotyfService _notyfService;

        public ProductController(IProductService productManager, ICategoryService categoryManager, IImageHelper imageHelper, INotyfService notyfService)
        {
            _productManager = productManager;
            _categoryManager = categoryManager;
            _imageHelper = imageHelper;
            _notyfService = notyfService;
        }


        [AllowAnonymous]
        public async Task<IActionResult> Index(bool isdeleted = false)
        {
            Response<List<ProductViewModel>> result = await _productManager.GetAllNonDeletedAsync(isdeleted);
            ViewBag.ShowDeleted = isdeleted;
            return View(result.Data);

        }

        public async Task<IActionResult> UpdateIsHome(int id)
        {
            var result = await _productManager.UpdateIsHomeAsync(id);
            var product = await _productManager.GetByIdAsync(id);
            return Json(product.Data.IsHome);
        }

        public async Task<IActionResult> UpdateIsActive(int id)
        {
            var result = await _productManager.UpdateIsActiveAsync(id);
            var product = await _productManager.GetByIdAsync(id);
            return Json(product.Data.IsHome);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var categories = await _categoryManager.GetActiveCategories();
            AddProductViewModel model = new AddProductViewModel
            {
                Categories = categories.Data
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddProductViewModel model, IFormFile image)
        {
            if (ModelState.IsValid && model.CategoryIds.Count > 0 && image != null)
            {
                model.ImageUrl = await _imageHelper.UploadImage(image, "products");
                model.Url = Jobs.GetUrl(model.Name);
                var result = await _productManager.CreateAsync(model);
                if (result.IsSucceeded)
                    _notyfService.Success("Ürün başarıyla kaydedilmiştir.");
                else
                    _notyfService.Error(result.Error);
                return RedirectToAction("Index");
            }
            //ViewBag.CategoryErrorMessage = model.CategoryIds.Count == 0 ? "Herhangi bir kategori seçmeden, ürün kaydı yapılamaz" : null;
            if (model.CategoryIds.Count == 0) _notyfService.Error("En az bir kategori seçmelisiniz.");
            ViewBag.ImageErrorMessage = model.ImageUrl == null || model.ImageUrl == "" ? "Resim hatalı!" : null;
            var categories = await _categoryManager.GetActiveCategories();
            model.Categories = categories.Data;
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var product = await _productManager.GetProductWithCategoriesAsync(id);
            ProductViewModel productViewModel = product.Data;
            var categories = await _categoryManager.GetActiveCategories();
            EditProductViewModel model = new EditProductViewModel
            {
                Id = productViewModel.Id,
                Name = productViewModel.Name,
                ImageUrl = productViewModel.ImageUrl,
                IsActive = productViewModel.IsActive,
                IsHome = productViewModel.IsHome,
                Price = productViewModel.Price,
                Properties = productViewModel.Properties,
                Url = productViewModel.Url,
                CategoryIds = productViewModel.CategoryList.Select(c => c.Id).ToList(),
                Categories = categories.Data,
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditProductViewModel model, IFormFile image)
        {
            if (ModelState.IsValid && model.CategoryIds.Count > 0)
            {
                if (image != null)
                {
                    model.ImageUrl = await _imageHelper.UploadImage(image, "products");
                }
                model.Url = Jobs.GetUrl(model.Name);
                var result = await _productManager.UpdateAsync(model);
                if (result.IsSucceeded)
                    _notyfService.Success("Ürün başarıyla güncellenmiştir.");
                else
                    _notyfService.Error(result.Error);
                return RedirectToAction("Index");
            }
            ViewBag.CategoryErrorMessage = model.CategoryIds.Count == 0 ? "Herhangi bir kategori seçmeden, ürün kaydı yapılamaz" : null;
            var categories = await _categoryManager.GetActiveCategories();
            model.Categories = categories.Data;
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _productManager.GetByIdAsync(id);
            ProductViewModel productViewModel = product.Data;
            DeleteProductViewModel model = new DeleteProductViewModel
            {
                Id = productViewModel.Id,
                Name = productViewModel.Name,
                Price = productViewModel.Price,
                CreatedDate = productViewModel.CreatedDate,
                ModifiedDate = productViewModel.ModifiedDate,
                IsDeleted = productViewModel.IsDeleted,
                ImageUrl = productViewModel.ImageUrl
            };
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> HardDelete(int id)
        {
            await _productManager.HardDeleteAsync(id);
            _notyfService.Success("Ürün kalıcı olarak silinmiştir.");
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> SoftDelete(int id)
        {
            await _productManager.SoftDeleteAsync(id);
            var productViewModel = await _productManager.GetByIdAsync(id);
            if (productViewModel.Data.IsDeleted)
                _notyfService.Success("Ürün çöp kutusuna gönderilmiştir.");
            else
                _notyfService.Success("Ürün çöp kutusundan başarıyla çıkartılmıştır.");
            return Redirect($"/Admin/Product/Index/{!productViewModel.Data.IsDeleted}");
        }


    }
}
