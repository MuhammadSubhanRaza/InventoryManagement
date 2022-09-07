using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendInventory.Models
{
    public class PurchaseDetails
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public float BuyingPrice { get; set; }
        [Required]
        public float RetailPrice { get; set; }
        public float TotalAmount { get; set; }

        [ForeignKey("Purchase")]
        public int PurchaseId { get; set; }
        public Purchase Purchase { get; set; }


        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
