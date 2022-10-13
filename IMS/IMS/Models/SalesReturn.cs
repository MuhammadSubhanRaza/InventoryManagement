using System;
using System.Collections.Generic;

namespace IMS.Models
{
    public partial class SalesReturn
    {
        public int Id { get; set; }
        public int? SalesId { get; set; }
        public int? ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal AmountReturned { get; set; }

        public virtual Product? Product { get; set; }
        public virtual Sale? Sales { get; set; }
    }
}
