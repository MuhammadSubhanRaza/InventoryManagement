using System;
using System.Collections.Generic;

namespace IMS.Models
{
    public partial class Offer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
    }
}
