using System;
using System.Collections.Generic;

namespace IMS.Models
{
    public partial class Product
    {
        public Product()
        {
            Purchases = new HashSet<Purchase>();
            SalesDetails = new HashSet<SalesDetail>();
            SalesReturns = new HashSet<SalesReturn>();
            Stocks = new HashSet<Stock>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Barcode { get; set; }
        public double? Weight { get; set; }
        public string? Description { get; set; }
        public DateTime? Expirydate { get; set; }
        public double? Price { get; set; }
        public int? Categoryid { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
        public virtual ICollection<SalesReturn> SalesReturns { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
