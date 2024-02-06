using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MiniShop.MVC.Areas.Admin.Models;
using MiniShop.MVC.Helpers;
using System.Text;
using System.Text.Json;
using MiniShopUI.Extensions;


namespace MiniShopUI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class CategoryController : Controller
    {

        public async Task<IActionResult> Index(bool id = false)
        {
            Response<List<CategoryViewModel>> response = new Response<List<CategoryViewModel>>();
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseApi = await httpClient.GetAsync($"http://localhost:7700/categories/nondeleteds/{id}");
                string contentResponseApi = await responseApi.Content.ReadAsStringAsync();
                response = JsonSerializer.Deserialize<Response<List<CategoryViewModel>>>(contentResponseApi);
            }
            ViewBag.ShowDeleted = id;
            return View(response.Data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            AddCategoryViewModel model = new AddCategoryViewModel
            {

            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddCategoryViewModel model, IFormFile image)
        {
            model.Url = Jobs.GetUrl(model.Name);
            if (ModelState.IsValid && image != null)
            {
                using (var httpClient = new HttpClient())
                {
                    //Resim Yükleme işlemi
                    using (var stream = image.OpenReadStream())
                    {
                        var imageContent = new MultipartFormDataContent();
                        byte[] bytes = stream.ToByteArray();
                        imageContent.Add(new ByteArrayContent(bytes), "image", image.FileName);
                        HttpResponseMessage httpResponseMessage = await httpClient.PostAsync("http://localhost:7700/Products/ImageUpload", imageContent);
                        string httpResponseMessageImageUrl = await httpResponseMessage.Content.ReadAsStringAsync();
                        if (httpResponseMessageImageUrl != null && httpResponseMessageImageUrl != "")
                        {
                            model.ImageUrl = httpResponseMessageImageUrl;
                            //Product Kayıt işlemi 
                            var serializeModel = JsonSerializer.Serialize(model);
                            StringContent stringContent = new StringContent(serializeModel, Encoding.UTF8, "application/json");
                            var result = await httpClient.PostAsync("http://localhost:7700/Categories/Add", stringContent);
                            if (result.IsSuccessStatusCode)
                            {
                                return RedirectToAction("Index");
                            }
                        }
                    }
                }
            }
            ViewBag.ImageErrorMessage = model.ImageUrl == null || model.ImageUrl == "" ? "Resim hatalı!" : null;
            return View(model);
        }




    }
}