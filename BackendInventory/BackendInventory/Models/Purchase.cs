using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendInventory.Models
{
    public class Purchase
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime PurchaseDate { get; set; }
        [Required]
        public float TotalAmount { get; set; }
        public float Discount { get; set; }

        [Required]
        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}
