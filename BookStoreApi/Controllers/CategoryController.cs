using BookStoreApi.Models;
using BookStoreApi.Reposities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryReposities _categoryRepo;

        public CategoryController(ICategoryReposities repository)
        {

            _categoryRepo = repository;
        }
        [HttpGet("allCategory")]
        public async Task<IActionResult> GetAllCategory ()
        {
            try
            {
                return Ok(await _categoryRepo.getAllCategoryAsync());

            }
            catch
            {
                return BadRequest();
            }

        }

        [HttpGet("getCategoryById")]
        public async Task<IActionResult> GetCategoryById(int categoryId)
        {
            var category = await _categoryRepo.getCategoryAsync(categoryId);
            return category == null ? NotFound() : Ok(category);
        }
        [HttpPost("addCategory")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddNewCategory(string categoryName)
        {
            try
            {
                var newcategoryId = await _categoryRepo.AddCategoryAsync(categoryName);
                var category = await _categoryRepo.getCategoryAsync(newcategoryId);
                return category == null ? NotFound() : Ok(category);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("updateCategory")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateCategory(int categoryId, string categoryName)
        {
            if (categoryId == null)
            {
                return NotFound();
            }
            await _categoryRepo.UpdateCategoryAsync(categoryId, categoryName);
            return Ok();
        }
        [HttpDelete("deleteCategory")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteCategory(int categoryId)
        {
            var resual = await _categoryRepo.DeleteCategoryAsync(categoryId);
            if (resual == 0)
            {
                return Ok();
            }
            return BadRequest();

        }
    }
}
