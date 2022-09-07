using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendInventory.Models
{
    public class Pricing
    {
        [Key]
        public int Id { get; set; }
        public float BuyingPrice { get; set; }
        public float SellingPrice { get; set; }
        public float Discount { get; set; }
        public float ProfitRatio { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
