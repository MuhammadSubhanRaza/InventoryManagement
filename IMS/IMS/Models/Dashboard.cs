namespace IMS.Models
{
    public class Dashboard
    {

        public decimal? TotalSales { get; set; }
        public int TotalProducts { get; set; }
        public double? TotalPurchase { get; set; }
        public int TotalCategories { get; set; }

        public IEnumerable<Product> Products { get; set; }

    }
}
