using BookStoreApi.Models;
using BookStoreApi.Reposities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartItemController : ControllerBase
    {
        private readonly ICartItemPeposities _cartItemRepo;

        public CartItemController(ICartItemPeposities repository)
        {

            _cartItemRepo = repository;
        }

        [HttpPost("addCartItem")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> AddNewCartItem(int quantity, int bookId, string memberId)
        {
            try
            {
                var newCarItem = await _cartItemRepo.AddCartItemAsync(quantity, bookId, memberId);
                if (newCarItem == 0 || newCarItem ==1)
                {
                    return Ok();
                }
                else { return NotFound(); }
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("updateCartItem")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> UpdateCartItem(int cartItemId, int quantity)
        {
            var resual =  await _cartItemRepo.UpdateCartItemAsync(cartItemId, quantity);
            if(resual == 0)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("deleteCartItem")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> DeleteCartItem(int Id)
        {
            await _cartItemRepo.DeleteCartItemAsync(Id);
            return Ok();
        }

        [HttpPost("getcartItemOfcart")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> getcartItemOfcart(string memberId)
        {
            try
            {
                var result = _cartItemRepo.getAllCartItemOfCartAsync(memberId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
