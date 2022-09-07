using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendInventory.Models
{
    public class SalesReturn
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int AmountReturned { get; set; }

        [ForeignKey("Sales")]
        public int SalesId { get; set; }
        public Sales Sales { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
