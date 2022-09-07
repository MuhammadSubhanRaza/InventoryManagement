using System.ComponentModel.DataAnnotations;

namespace BackendInventory.Models
{
    public class SalesReturnRatio
    {
        [Key]
        public int Id { get; set; }
        public float Ratio { get; set; } = 0;

    }
}
