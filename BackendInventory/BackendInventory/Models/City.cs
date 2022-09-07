using System.ComponentModel.DataAnnotations;

namespace BackendInventory.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(length:60)]
        public string Name { get; set; }


        public ICollection<Supplier> Suppliers { get; set; }
    }
}
