using System;
using System.Collections.Generic;

namespace IMS.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Sales = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Contact { get; set; } = null!;
        public string Email { get; set; } = null!;

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
