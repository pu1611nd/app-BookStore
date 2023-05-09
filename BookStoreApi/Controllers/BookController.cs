using BookStoreApi.Models;
using BookStoreApi.Reposities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookReposities _bookRepo;

        public BookController(IBookReposities repository)
        {
            _bookRepo = repository;
        }

        [HttpGet("getAllBook")]
        public async Task<IActionResult> GetALLBook(int page = 1)
        {
            try
            {
                return Ok(await _bookRepo.getAllBookAsync(page));
            }
            catch
            {
                return BadRequest();
            }

        }

        [HttpGet("getBookById")]
        public async Task<IActionResult> GetBookById(int bookId)
        {
            var book = await _bookRepo.getBookAsync(bookId);
            return book == null ? NotFound() : Ok(book);
        }

        [HttpGet("getBookInfo")]
        public async Task<IActionResult> GetBookInfo(int bookId)
        {
            var book = await _bookRepo.GetBookInfoAsync(bookId);
            return book == null ? NotFound() : Ok(book);
        }
        [HttpPost("addBook")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddNewBook(BookAdd model)
        {
            try
            {
                var newBookId = await _bookRepo.AddBookAsync(model);
                var book = await _bookRepo.getBookAsync(newBookId);
                return book == null ? NotFound() : Ok(book);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("updateBook")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateBook(int bookId, BookModel model)
        {
            if (bookId != model.ProductId)
            {
                return NotFound();
            }
            await _bookRepo.UpdateBookAsync(bookId, model);
            return Ok();
        }
        [HttpDelete("deleteBook")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteBook(int bookId)
        {


            var resual = await _bookRepo.DeleteBookAsync(bookId);
            if (resual == 0)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("searchOfTitle")]
        public async Task<IActionResult> GetAllBookOfTitleAsync( string search, int page = 1)
        {
            try
            {
                var result = _bookRepo.GetAllBookOfTitleAsync(search,page);
                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("bookOfcategory")]
        public async Task<IActionResult> GetBookOfCatgoryAsync(int categoryId, int page = 1)
        {
            try
            {
                var result = _bookRepo.GetBookOfCatgoryAsync(categoryId,page);
                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("randomBook")]
        public async Task<IActionResult> GetrandomBook()
        {
            try
            {
                var result = _bookRepo.GetRandomBook();
                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}
