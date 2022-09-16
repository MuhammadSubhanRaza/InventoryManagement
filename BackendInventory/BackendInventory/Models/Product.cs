using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendInventory.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(length:100)]
        public string Name { get; set; }
        public string Weight { get; set; }
        public string Description { get; set; }
        public string ExpiryDate { get; set; }
        public string? ImagePath { get; set; }
        [Required]

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
