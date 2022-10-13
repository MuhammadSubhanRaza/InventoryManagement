using System;
using System.Collections.Generic;

namespace IMS.Models
{
    public partial class Sale
    {
        public Sale()
        {
            SalesDetails = new HashSet<SalesDetail>();
            SalesReturns = new HashSet<SalesReturn>();
        }

        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? TotalDiscount { get; set; }

        public virtual Employee? Employee { get; set; }
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
        public virtual ICollection<SalesReturn> SalesReturns { get; set; }
    }
}
