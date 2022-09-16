using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendInventory.Models
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(length:150)]
        public string CompanyName { get; set; }
        [Required]
        [MaxLength(length: 20)]
        public string RegNumber { get; set; }
        [Required]
        [MaxLength(length: 20)]
        public string ContactNo { get; set; }
        public string Address { get; set; }
        [Required]
        [MaxLength(length: 100)]
        public  string SupplierName { get; set; }
        [Required]
        [MaxLength(length: 20)]
        public string SupplierContact { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }
        public City? City { get; set; }

    }
}
