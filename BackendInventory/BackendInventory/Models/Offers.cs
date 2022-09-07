using System.ComponentModel.DataAnnotations;

namespace BackendInventory.Models
{
    public class Offers
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(length:100)]
        public string Name { get; set; }
        [Required]
        public DateTime StartingDate { get; set; }
        [Required]
        public DateTime EndingDate { get; set; }

    }
}
