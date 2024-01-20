using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Shared.DTOs;

namespace MiniShop.API.Controllers
{
    //localhost:5000/api/Categories
    [Route("[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryManager;

        public CategoriesController(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _categoryManager.GetAllAsync();
            var JsonResponse = JsonSerializer.Serialize(response);
            return Ok(JsonResponse);
        }

        [HttpGet("getwithproducts")]
        public async Task<IActionResult> GetWithProducts()
        {
            var response = await _categoryManager.GetAllCategoriesWithProductsAsync();
            var JsonResponse = JsonSerializer.Serialize(response);
            return Ok(JsonResponse);
        }

        [HttpGet("getbyid/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _categoryManager.GetByIdAsync(id);
            var JsonResponse = JsonSerializer.Serialize(response);
            return Ok(JsonResponse);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Create(AddCategoryDTO addCategoryDTO)
        {
            var response = await _categoryManager.CreateAsync(addCategoryDTO);
            var JsonResponse = JsonSerializer.Serialize(response);
            return Ok(JsonResponse);
        }

        [HttpPut("update")] //Bu metot guncelleme islemlerinde kullanilir.
        public async Task<IActionResult> Update(EditCategoryDTO editCategoryDTO)
        {
            var response = await _categoryManager.UpdateAsync(editCategoryDTO);
            var JsonResponse = JsonSerializer.Serialize(response);
            return Ok(JsonResponse);
        }
        [HttpDelete("harddelete/{id}")]
        public async Task<IActionResult> HardDelete(int id)
        {
            var response = await _categoryManager.HardDeleteAsync(id);
            var JsonResponse = JsonSerializer.Serialize(response);
            return Ok(JsonResponse);
        }
        [HttpDelete("softdelete/{id}")]
        public async Task<IActionResult> SoftDelete(int id)
        {
            var response = await _categoryManager.SoftDeleteAsync(id);
            var JsonResponse = JsonSerializer.Serialize(response);
            return Ok(JsonResponse);
        }
    }
}
