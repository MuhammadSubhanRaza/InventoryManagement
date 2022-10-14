using IMS.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {

        private readonly inventoryDbContext _context;

        public DashboardController(inventoryDbContext context)
        {
            _context = context;
        }

        // GET: api/<DashboardController>
        [HttpGet]
        public Dashboard Get()
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Products = _context.Products.ToList();
            dashboard.TotalSales = this.getTotalSales();
            dashboard.TotalCategories = this.getTotalCategories();
            dashboard.TotalProducts = this.getTotalProducts();
            dashboard.TotalPurchase = this.getTotalPurchases();


            return dashboard;
        }

        private decimal? getTotalSales()
        {
            decimal? sales = 0;
            foreach (var item in _context.Sales.ToList())
            {
                sales += item.TotalAmount;
            }

            return sales;
        }

        private int getTotalProducts()
        {
            return _context.Products.Count(); 
        }

        private int getTotalCategories()
        {
            return _context.Categories.Count(); 
        }

        private double? getTotalPurchases()
        {
            double? purchase = 0;
            foreach (var item in _context.Purchases.ToList())
            {
                purchase += (item.PricePerUnit * item.Quantity);
            }

            return purchase;
        }

        // GET api/<DashboardController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DashboardController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DashboardController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DashboardController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
