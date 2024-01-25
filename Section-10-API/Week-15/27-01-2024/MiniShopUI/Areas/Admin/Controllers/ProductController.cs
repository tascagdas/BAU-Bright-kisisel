using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using MiniShop.MVC.Areas.Admin.Models;

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
                var responseApi = await httpClient.GetAsync("http://localhost:7700/products");
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
                RequestUri = new Uri($"http://localhost:7700/products/updateishome/{id}"),
                Content = new StringContent("", System.Text.Encoding.UTF8, "application/json")
            };
            HttpResponseMessage response = await httpClient.SendAsync(request);
            return RedirectToAction("Index");
        }
    }
}
