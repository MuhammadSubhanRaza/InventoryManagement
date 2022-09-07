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
    public class PricingsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PricingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Pricings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pricing>>> GetPricings()
        {
          if (_context.Pricings == null)
          {
              return NotFound();
          }
            return await _context.Pricings.ToListAsync();
        }

        // GET: api/Pricings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pricing>> GetPricing(int id)
        {
          if (_context.Pricings == null)
          {
              return NotFound();
          }
            var pricing = await _context.Pricings.FindAsync(id);

            if (pricing == null)
            {
                return NotFound();
            }

            return pricing;
        }

        // PUT: api/Pricings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPricing(int id, Pricing pricing)
        {
            if (id != pricing.Id)
            {
                return BadRequest();
            }

            _context.Entry(pricing).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PricingExists(id))
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

        // POST: api/Pricings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pricing>> PostPricing(Pricing pricing)
        {
          if (_context.Pricings == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Pricings'  is null.");
          }
            _context.Pricings.Add(pricing);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPricing", new { id = pricing.Id }, pricing);
        }

        // DELETE: api/Pricings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePricing(int id)
        {
            if (_context.Pricings == null)
            {
                return NotFound();
            }
            var pricing = await _context.Pricings.FindAsync(id);
            if (pricing == null)
            {
                return NotFound();
            }

            _context.Pricings.Remove(pricing);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PricingExists(int id)
        {
            return (_context.Pricings?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
