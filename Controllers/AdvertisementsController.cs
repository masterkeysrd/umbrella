using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using umbrella.Models;

namespace umbrella.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertisementsController : ControllerBase
    {
        private readonly umbrellaContext _context;

        public AdvertisementsController(umbrellaContext context)
        {
            _context = context;
        }

        // GET: api/Advertisements
        [HttpGet]
        public IEnumerable<Advertisement> GetAdvertisement()
        {
            return _context.Advertisement;
        }

        // GET: api/Advertisements/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAdvertisement([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var advertisement = await _context.Advertisement.FindAsync(id);

            if (advertisement == null)
            {
                return NotFound();
            }

            return Ok(advertisement);
        }

        // PUT: api/Advertisements/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdvertisement([FromRoute] long id, [FromBody] Advertisement advertisement)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != advertisement.Id)
            {
                return BadRequest();
            }

            _context.Entry(advertisement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdvertisementExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Advertisements
        [HttpPost]
        public async Task<IActionResult> PostAdvertisement([FromBody] Advertisement advertisement)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Advertisement.Add(advertisement);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdvertisement", new { id = advertisement.Id }, advertisement);
        }

        // DELETE: api/Advertisements/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdvertisement([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var advertisement = await _context.Advertisement.FindAsync(id);
            if (advertisement == null)
            {
                return NotFound();
            }

            _context.Advertisement.Remove(advertisement);
            await _context.SaveChangesAsync();

            return Ok(advertisement);
        }

        private bool AdvertisementExists(long id)
        {
            return _context.Advertisement.Any(e => e.Id == id);
        }
    }
}