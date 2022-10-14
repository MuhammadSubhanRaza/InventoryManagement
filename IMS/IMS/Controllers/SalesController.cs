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
    public class SalesController : ControllerBase
    {
        private readonly inventoryDbContext _context;

        public SalesController(inventoryDbContext context)
        {
            _context = context;
        }

        // GET: api/Sales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sale>>> GetSales()
        {
            var list = await _context.Sales.Include(e=>e.SalesDetails).ToListAsync();
            return list;
        }

        // GET: api/Sales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sale>> GetSale(int id)
        {
            var sale = await _context.Sales.FindAsync(id);

            if (sale == null)
            {
                return NotFound();
            }

            return sale;
        }

        // PUT: api/Sales/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSale(int id, Sale sale)
        {
            if (id != sale.Id)
            {
                return BadRequest();
            }

            _context.Entry(sale).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SaleExists(id))
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

        // POST: api/Sales
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Sale>> PostSale(Sale sale)
        //{
        //    _context.Sales.Add(sale);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetSale", new { id = sale.Id }, sale);
        //}


        [HttpPost]
        public async Task<ActionResult<Sale>> PostSale(List<SalesConfirm> salesConfirms)
        {
            decimal grandTotal = 0;
            decimal grandDiscount =0;
            foreach (SalesConfirm item in salesConfirms) {
                grandTotal += item.price * item.Quantity;
            }

            var sale = new Sale(){ EmployeeId=1,TotalAmount=grandTotal,TotalDiscount=grandDiscount,Date=DateTime.Now};
            this._context.Sales.Add(sale);
            await this._context.SaveChangesAsync();

            var currentSaleId = sale.Id;

            foreach (SalesConfirm item in salesConfirms)
            {
                SalesDetail salesDetail = new SalesDetail() {
                    ProductId = item.ProductId,
                    SalesId = currentSaleId,
                    Quantity = item.Quantity,
                    TotalAmount = item.price * item.Quantity,
                    TotalDiscount = 0
                };
                _context.SalesDetails.Add(salesDetail);
                await _context.SaveChangesAsync();
            }

            return null;
        }



        // DELETE: api/Sales/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSale(int id)
        {
            var sale = await _context.Sales.FindAsync(id);
            if (sale == null)
            {
                return NotFound();
            }

            _context.Sales.Remove(sale);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SaleExists(int id)
        {
            return _context.Sales.Any(e => e.Id == id);
        }
    }
}
