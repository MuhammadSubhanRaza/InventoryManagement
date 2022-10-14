using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IMS.Models;

namespace IMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesReturnsController : ControllerBase
    {
        private readonly inventoryDbContext _context;

        public SalesReturnsController(inventoryDbContext context)
        {
            _context = context;
        }

        // GET: api/SalesReturns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesReturn>>> GetSalesReturns()
        {
            return await _context.SalesReturns.ToListAsync();
        }

        // GET: api/SalesReturns/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SalesReturn>> GetSalesReturn(int id)
        {
            var salesReturn = await _context.SalesReturns.FindAsync(id);

            if (salesReturn == null)
            {
                return NotFound();
            }

            return salesReturn;
        }

        // PUT: api/SalesReturns/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalesReturn(int id, SalesReturn salesReturn)
        {
            if (id != salesReturn.Id)
            {
                return BadRequest();
            }

            _context.Entry(salesReturn).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesReturnExists(id))
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

        // POST: api/SalesReturns
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SalesReturn>> PostSalesReturn(SalesReturn salesReturn)
        {
            _context.SalesReturns.Add(salesReturn);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalesReturn", new { id = salesReturn.Id }, salesReturn);
        }

        // DELETE: api/SalesReturns/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSalesReturn(int id)
        {
            var salesReturn = await _context.SalesReturns.FindAsync(id);
            if (salesReturn == null)
            {
                return NotFound();
            }

            _context.SalesReturns.Remove(salesReturn);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SalesReturnExists(int id)
        {
            return _context.SalesReturns.Any(e => e.Id == id);
        }
    }
}
