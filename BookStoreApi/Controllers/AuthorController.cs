using BookStoreApi.Models;
using BookStoreApi.Reposities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorReposities _authorRepo;

        public AuthorController(IAuthorReposities repository)
        {

            _authorRepo = repository;
        }
        [HttpGet("getAllAuthor")]

        public async Task<IActionResult> GetAllAuthor()
        {
            try
            {
                return Ok(await _authorRepo.getAllAuthorAsync());

            }
            catch
            {
                return BadRequest();
            }

        }

        [HttpGet("getAuthorById")]
        public async Task<IActionResult> GetAuthorById(int authorId)
        {
            var author = await _authorRepo.getAuthorAsync(authorId);
            return author == null ? NotFound() : Ok(author);
        }
        [HttpPost("addAuthor")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddAuthorAsync(string authorName)
        {
            try
            {
                var newAuthorId = await _authorRepo.AddAuthorAsync(authorName);
                var author = await _authorRepo.getAuthorAsync(newAuthorId);
                return author == null ? NotFound() : Ok(author);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("updateAuthor")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateAuthor(int authorId, string authorName)
        {
            if (authorId == null)
            {
                return NotFound();
            }
            await _authorRepo.UpdateAuthorAsync(authorId, authorName);
            return Ok();
        }
        [HttpDelete("deleteAuthor")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteAuthor(int authorId)
        {
            var resual = await _authorRepo.DeleteAuthorAsync(authorId);
            if (resual == 0)
            {
                return Ok();
            }
            return BadRequest();
        }


    }
}
