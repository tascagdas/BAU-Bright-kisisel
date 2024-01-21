using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;

namespace MiniShop.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productManager;

        public ProductsController(IProductService productManager)
        {
            _productManager = productManager;
        }
        [HttpGet("getall")]
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
        [HttpGet("getbycategoryid/{categoryid}")]
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































    }
}