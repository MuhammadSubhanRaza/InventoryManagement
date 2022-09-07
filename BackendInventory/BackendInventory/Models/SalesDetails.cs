using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendInventory.Models
{
    public class SalesDetails
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }
        public int TotalAmount { get; set; }
        public int TotalDiscount { get; set; } = 0;

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }


        [ForeignKey("Sales")]
        public int SalesId { get; set; }
        public Sales Sales { get; set; }
    }
}
