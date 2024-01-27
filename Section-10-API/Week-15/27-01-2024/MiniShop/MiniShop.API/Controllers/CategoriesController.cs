using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Shared.DTOs;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MiniShop.API.Controllers
{
    //localhost:5000/api/Categories
    //[Route("[controller]/[action]")]
    [Route("[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryManager;

        public CategoriesController(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _categoryManager.GetAllAsync();
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _categoryManager.GetByIdAsync(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Create(AddCategoryDTO addCategoryDto)
        {
            var response = await _categoryManager.CreateAsync(addCategoryDto);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(EditCategoryDTO editCategoryDto)
        {
            var response = await _categoryManager.UpdateAsync(editCategoryDto);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpGet("HardDelete/{id}")]
        public async Task<IActionResult> HardDelete(int id)
        {
            var response = await _categoryManager.HardDeleteAsync(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpGet("SoftDelete/{id}")]
        public async Task<IActionResult> SoftDelete(int id)
        {
            var response = await _categoryManager.SoftDeleteAsync(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpGet("NonDeleteds/{isDeleted?}")]
        public async Task<IActionResult> GetNonDeleted(bool isDeleted = false)
        {
            var response = await _categoryManager.GetNonDeletedCategories(isDeleted);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpGet("Actives/{isActive?}")]
        public async Task<IActionResult> GetActives(bool isActive = true)
        {
            var response = await _categoryManager.GetActiveCategories(isActive);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpGet("ActiveCount")]
        public async Task<IActionResult> GetActiveCount()
        {
            var response = await _categoryManager.GetActiveCategoryCount();
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpGet("Count")]
        public async Task<IActionResult> GetCount()
        {
            var response = await _categoryManager.GetCategoryCount();
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }
    }
}
