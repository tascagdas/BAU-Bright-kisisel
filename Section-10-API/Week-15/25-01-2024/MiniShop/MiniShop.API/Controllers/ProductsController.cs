using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Shared.DTOs;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MiniShop.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productManager;

        public ProductsController(IProductService productManager)
        {
            _productManager = productManager;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _productManager.GetAllAsync();
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpGet("getwithcategories")]
        public async Task<IActionResult> GetWithCategories()
        {
            var response = await _productManager.GetAllProductsWithCategoriesAsync();
            //var options = new JsonSerializerOptions
            //{
            //    ReferenceHandler = ReferenceHandler.IgnoreCycles
            //};
            //var jsonResponse = JsonSerializer.Serialize(response, options);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpGet("getbyid/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _productManager.GetByIdAsync(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpGet("getproductwithcategories/{id}")]
        public async Task<IActionResult> GetProductWithCategories(int id)
        {
            var response = await _productManager.GetProductWithCategoriesAsync(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpGet("getbycategoryid/{categoryId}")]
        public async Task<IActionResult> GetByCategoryId(int categoryId)
        {
            var response = await _productManager.GetProductsByCategoryIdAsync(categoryId);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(AddProductDTO addProductDTO)
        {
            var response = await _productManager.CreateAsync(addProductDTO);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(EditProductDTO editProductDTO)
        {
            //Ürünün kategori bilgilerinin güncellenmesi gerçekleşmiyor.
            //MVC tarafını geliştirirken, bu meseleyi çözeceğiz.
            var response = await _productManager.UpdateAsync(editProductDTO);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpDelete("harddelete/{id}")]
        public async Task<IActionResult> HardDelete(int id)
        {
            var response = await _productManager.HardDeleteAsync(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpDelete("softdelete/{id}")]
        public async Task<IActionResult> SoftDelete(int id)
        {
            var response = await _productManager.SoftDeleteAsync(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }
    }
}
