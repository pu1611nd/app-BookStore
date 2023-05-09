using BookStoreApi.Models;
using BookStoreApi.Reposities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        private readonly IPublisherReposities _publisherRepo;

        public PublisherController(IPublisherReposities repository)
        {

            _publisherRepo = repository;
        }
        [HttpGet("getAllPublisher")]
        public async Task<IActionResult> GetAllPublisher()
        {
            try
            {
                return Ok(await _publisherRepo.getAllPublisherAsync());

            }
            catch
            {
                return BadRequest();
            }

        }

        [HttpGet("getPublisherById")]
        public async Task<IActionResult> GetPublisherById(int publisherId)
        {
            var publisher = await _publisherRepo.getPublisherAsync(publisherId);
            return publisher == null ? NotFound() : Ok(publisher);
        }
        [HttpPost("addPublisher")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddPublisherAsync(string publisherName)
        {
            try
            {
                var newPublisherId = await _publisherRepo.AddPublisherAsync(publisherName);
                var publisher = await _publisherRepo.getPublisherAsync(newPublisherId);
                return publisher == null ? NotFound() : Ok(publisher);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("updatePublisher")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdatePublisher(int publisherId, string publisherName)
        {
            if (publisherId == null)
            {
                return NotFound();
            }
            await _publisherRepo.UpdatePublisherAsync(publisherId,publisherName);
            return Ok();
        }
        [HttpDelete("deletePublisher")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeletePublisher(int publisherId)
        {


            var resual =  await _publisherRepo.DeletePublisherAsync(publisherId);
            if(resual == 0)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
