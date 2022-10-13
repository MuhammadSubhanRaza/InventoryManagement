using System;
using System.Collections.Generic;

namespace IMS.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Purchases = new HashSet<Purchase>();
        }

        public int Id { get; set; }
        public string Companyname { get; set; } = null!;
        public string RegestrationNo { get; set; } = null!;
        public string ContactNo { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string? City { get; set; }
        public string SupplierName { get; set; } = null!;
        public string? SupplierContact { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
