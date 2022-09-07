using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackendInventory.Data;
using BackendInventory.Models;

namespace BackendInventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OffersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OffersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Offers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Offers>>> GetOffers()
        {
          if (_context.Offers == null)
          {
              return NotFound();
          }
            return await _context.Offers.ToListAsync();
        }

        // GET: api/Offers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Offers>> GetOffers(int id)
        {
          if (_context.Offers == null)
          {
              return NotFound();
          }
            var offers = await _context.Offers.FindAsync(id);

            if (offers == null)
            {
                return NotFound();
            }

            return offers;
        }

        // PUT: api/Offers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOffers(int id, Offers offers)
        {
            if (id != offers.Id)
            {
                return BadRequest();
            }

            _context.Entry(offers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OffersExists(id))
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

        // POST: api/Offers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Offers>> PostOffers(Offers offers)
        {
          if (_context.Offers == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Offers'  is null.");
          }
            _context.Offers.Add(offers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOffers", new { id = offers.Id }, offers);
        }

        // DELETE: api/Offers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOffers(int id)
        {
            if (_context.Offers == null)
            {
                return NotFound();
            }
            var offers = await _context.Offers.FindAsync(id);
            if (offers == null)
            {
                return NotFound();
            }

            _context.Offers.Remove(offers);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OffersExists(int id)
        {
            return (_context.Offers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
