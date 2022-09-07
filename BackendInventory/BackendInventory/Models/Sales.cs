using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendInventory.Models
{
    public class Sales
    {
        [Key]
        public int Id { get; set; }
        public DateTime SalesDate { get; set; }
        public float TotalAmount { get; set; }
        public float TotalDiscount { get; set; }

        [ForeignKey("Offers")]
        public int PromoId { get; set; } = 0;
        public Offers Offers { get; set; }


        [ForeignKey("User")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }


    }
}
