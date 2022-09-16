using BackendInventory.Data;
using BackendInventory.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendInventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchasesController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public PurchasesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Purchase>> PostPurchase(CustomPurchase customPurchase)
        {

            Purchase purchase = new Purchase() { 
                PurchaseDate = customPurchase.DateOfPurchase,
                TotalAmount = customPurchase.TotalAmount,
                Discount = customPurchase.Discount,
                SupplierId = customPurchase.SupplierId
            };

            this._context.Purchases.Add(purchase);
            this._context.SaveChanges();

            PurchaseDetails purchaseDetails = new PurchaseDetails() { 
                PurchaseId = purchase.Id,
                BuyingPrice = customPurchase.PricePerUnit,
                ProductId = customPurchase.ProductId,
                Quantity = customPurchase.Quantity,
                RetailPrice = customPurchase.RetailPrice,
                TotalAmount = customPurchase.Quantity * customPurchase.PricePerUnit
            };

            this._context.PurchaseDetails.Add(purchaseDetails);
            int res = this._context.SaveChanges();

            if (res > 0) {
                return Ok();
            }
            return Problem("Entity set 'ApplicationDbContext.Purchases'  is null.");
        }

    }
}
