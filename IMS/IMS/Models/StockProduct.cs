using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models
{
    [NotMapped]
    public class StockProduct
    {
        //public int Id { get; set; }
        //public string Product { get; set; }
        //public int Quantity { get; set; }

        public Stock StockList { get; set; }
        public Product ProductList { get; set; }
    }
}
