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
    public class SalesratiosController : ControllerBase
    {
        private readonly inventoryDbContext _context;

        public SalesratiosController(inventoryDbContext context)
        {
            _context = context;
        }

        // GET: api/Salesratios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesReturnRatio>>> GetSalesReturnRatios()
        {
            return await _context.SalesReturnRatios.ToListAsync();
        }

        // GET: api/Salesratios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SalesReturnRatio>> GetSalesReturnRatio(int id)
        {
            var salesReturnRatio = await _context.SalesReturnRatios.FindAsync(id);

            if (salesReturnRatio == null)
            {
                return NotFound();
            }

            return salesReturnRatio;
        }

        // PUT: api/Salesratios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalesReturnRatio(int id, SalesReturnRatio salesReturnRatio)
        {
            if (id != salesReturnRatio.Id)
            {
                return BadRequest();
            }

            _context.Entry(salesReturnRatio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesReturnRatioExists(id))
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

        // POST: api/Salesratios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SalesReturnRatio>> PostSalesReturnRatio(SalesReturnRatio salesReturnRatio)
        {
            _context.SalesReturnRatios.Add(salesReturnRatio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalesReturnRatio", new { id = salesReturnRatio.Id }, salesReturnRatio);
        }

        // DELETE: api/Salesratios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSalesReturnRatio(int id)
        {
            var salesReturnRatio = await _context.SalesReturnRatios.FindAsync(id);
            if (salesReturnRatio == null)
            {
                return NotFound();
            }

            _context.SalesReturnRatios.Remove(salesReturnRatio);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SalesReturnRatioExists(int id)
        {
            return _context.SalesReturnRatios.Any(e => e.Id == id);
        }
    }
}
