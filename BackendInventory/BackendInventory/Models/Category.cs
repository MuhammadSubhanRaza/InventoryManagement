using System.ComponentModel.DataAnnotations;

namespace BackendInventory.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(length:60)]
        public string Name { get; set; }
        public string Description { get; set; }


        public ICollection<Product> Products { get; set; }
    }
}
