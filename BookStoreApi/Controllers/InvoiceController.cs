using BookStoreApi.Models;
using BookStoreApi.Reposities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceReposities _invoiceRepo;

        public InvoiceController(IInvoiceReposities repository)
        {

            _invoiceRepo = repository;
        }
        [HttpGet("GetAllInvoice")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllInvoice()
        {
            try
            {
                return Ok(await _invoiceRepo.getAllInvoiceAsync());

            }
            catch
            {
                return BadRequest();
            }

        }

        [HttpGet("GetAllInvoiceOfStatus")]
        [Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> GetAllInvoiceOfStatus(int statusId)
        {
            try
            {
                return Ok(await _invoiceRepo.getInvoiceOfStatusAsync(statusId));

            }
            catch
            {
                return BadRequest();
            }

        }

        [HttpGet("InvoiceById")]
        [Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> InvoiceById(int invoiceId)
        {
            var invoice = await _invoiceRepo.getInvoiceAsync(invoiceId);
            return invoice == null ? NotFound() : Ok(invoice);
        }
        [HttpPost("addInvoice")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> AddNewInvoice(InvoiceAdd model)
        {
            try
            {
                var newInvoiceId = await _invoiceRepo.AddInvoiceAsync(model);
                var invoice = await _invoiceRepo.getInvoiceAsync(newInvoiceId);
                return invoice == null ? NotFound() : Ok(invoice);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("updateInvoice")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> UpdateInvoice(int invoiceId, InvoiceUpdate model)
        {
            if (invoiceId == null)
            {
                return NotFound();
            }
            await _invoiceRepo.UpdateInvoiceAsync(invoiceId, model);
            return Ok();
        }
        [HttpPut("updateStatusOfInvoice")]
        [Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> UpdateStatusOfInvoice(int invoiceId, int statusId)
        {
            if (invoiceId == null && statusId == null )
            {
                return NotFound();
            }
            await _invoiceRepo.UpdateStatusOfInvoiceAsync(invoiceId, statusId);
            return Ok();
        }

        [HttpDelete("deleteInvoice")]
        [Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> DeleteBook(int invoiceId)
        {


            await _invoiceRepo.DeleteInvoiceAsync(invoiceId);
            return Ok();
        }

        [HttpPost("searchOfmemberId")]
        [Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> GetInvoiceOfUserAsync(string memberId)
        {
            try
            {
                var result = _invoiceRepo.GetInvoiceOfUserAsync(memberId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
