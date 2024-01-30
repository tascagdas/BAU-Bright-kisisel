using Microsoft.AspNetCore.Mvc;
using MiniShop.MVC.Areas.Admin.Models;
using MiniShop.MVC.Helpers;
using System.Text;
using System.Text.Json;

namespace MiniShop.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        public async Task<IActionResult> Index()
        {
            Response<List<ProductViewModel>> response = new Response<List<ProductViewModel>>();
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseApi = await httpClient.GetAsync("http://localhost:7700/Products");
                string contentResponseApi = await responseApi.Content.ReadAsStringAsync();
                response = JsonSerializer.Deserialize<Response<List<ProductViewModel>>>(contentResponseApi);
            }
            
            return View(response.Data);
        }
        public async Task<IActionResult> UpdateIsHome(int id)
        {
            HttpClient httpClient = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri= new Uri($"http://localhost:7700/Products/UpdateIsHome/{id}"),
                Content=new StringContent("",Encoding.UTF8,"application/json")
            };
            HttpResponseMessage response = await httpClient.SendAsync(request);

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdateIsActive(int id)
        {
            HttpClient httpClient = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"http://localhost:7700/Products/UpdateIsActive/{id}"),
                Content = new StringContent("", Encoding.UTF8, "application/json")
            };
            HttpResponseMessage response = await httpClient.SendAsync(request);

            return RedirectToAction("Index");
        }

        [NonAction]
        public async Task<List<CategoryViewModel>> GetCategoriesAsync()
        {
            Response<List<CategoryViewModel>> response = new Response<List<CategoryViewModel>>();
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseApi = await httpClient.GetAsync("http://localhost:7700/Categories");
                string contentResponseApi = await responseApi.Content.ReadAsStringAsync();
                response = JsonSerializer.Deserialize<Response<List<CategoryViewModel>>>(contentResponseApi);
            }
            return response.Data;
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            AddProductViewModel model = new AddProductViewModel
            {
                Categories = await GetCategoriesAsync()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddProductViewModel model)
        {
            model.Properties = "Geçici olarak otomatik metin üretiliyor.";
            model.Url = Jobs.GetUrl(model.Name);
            if(ModelState.IsValid && model.CategoryIds.Count>0)
            {
                using (var httpClient = new HttpClient())
                {
                    var serializeModel = JsonSerializer.Serialize(model);
                    StringContent stringContent = new StringContent(serializeModel, Encoding.UTF8, "application/json");
                    var result = await httpClient.PostAsync("http://localhost:7700/Products/Create", stringContent);
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            ViewBag.CategoryErrorMessage = model.CategoryIds.Count == 0 ? "Herhangi bir kategori seçmeden, ürün kaydı yapılamaz" : null;
            model.Categories= await GetCategoriesAsync();
            return View(model);
        }

        [NonAction]
        public async Task<ProductViewModel> GetProductAsync(int id)
        {
            Response<ProductViewModel> response = new Response<ProductViewModel>();
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseApi = await httpClient.GetAsync($"http://localhost:7700/Products/GetWithCategories/{id}");
                string contentResponseApi = await responseApi.Content.ReadAsStringAsync();
                response = JsonSerializer.Deserialize<Response<ProductViewModel>>(contentResponseApi);
            }
            return response.Data;
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ProductViewModel productViewModel = await GetProductAsync(id);
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
                CategoryIds= productViewModel.Categories.Select(c=>c.Id).ToList(),
                Categories= await GetCategoriesAsync()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditProductViewModel model)
        {
            model.Properties = "Geçici olarak otomatik metin üretiliyor.";
            model.Url = Jobs.GetUrl(model.Name);
            if (ModelState.IsValid && model.CategoryIds.Count > 0)
            {
                using (var httpClient = new HttpClient())
                {
                    var serializeModel = JsonSerializer.Serialize(model);
                    StringContent stringContent = new StringContent(serializeModel, Encoding.UTF8, "application/json");
                    var result = await httpClient.PutAsync("http://localhost:7700/Products/Update", stringContent);
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            ViewBag.CategoryErrorMessage = model.CategoryIds.Count == 0 ? "Herhangi bir kategori seçmeden, ürün kaydı yapılamaz" : null;
            model.Categories = await GetCategoriesAsync();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            ProductViewModel productViewModel = await GetProductAsync(id);
            DeleteProductViewModel model = new DeleteProductViewModel
            {
                Id = productViewModel.Id,
                Name = productViewModel.Name,
                Price = productViewModel.Price,
                CreatedDate = productViewModel.CreatedDate,
                ModifiedDate = productViewModel.ModifiedDate,
                IsDeleted = productViewModel.IsDeleted,
            };
            return View(model);
        }
    }
}
