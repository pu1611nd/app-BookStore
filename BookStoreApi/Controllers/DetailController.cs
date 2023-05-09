using BookStoreApi.Models;
using BookStoreApi.Reposities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailController : ControllerBase
    {
        private readonly IDetailReposities _detailRepo;

        public DetailController(IDetailReposities repository)
        {

            _detailRepo = repository;
        } 
        [HttpPost("getDetaiByInvoiceId")]
        [Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> getDetaiByInvoiceId(int invoiceId)
        {
            try
            {
                return Ok(await _detailRepo.GetDetailOfInvoiceAsync(invoiceId));
            }
            catch
            {
                return BadRequest();
            }
        }  

    }
}
