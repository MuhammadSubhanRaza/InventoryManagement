using System;
using System.Collections.Generic;

namespace IMS.Models
{
    public partial class Purchase
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int? ProductId { get; set; }
        public int? SupplierId { get; set; }
        public double PricePerUnit { get; set; }
        public DateTime Date { get; set; }
        public decimal? TotalAmount { get; set; }

        public virtual Product? Product { get; set; }
        public virtual Supplier? Supplier { get; set; }
    }
}
