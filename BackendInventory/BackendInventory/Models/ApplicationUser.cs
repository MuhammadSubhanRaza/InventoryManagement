using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BackendInventory.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        public string? LastName { get; set; }

        [Required]
        public string CNIC { get; set; }
        public DateTime? DateOfBirth { get; set; }

        [Required]
        public DateTime JoiningDate { get; set; }

        [Required]
        public float Salary { get; set; }

        public string? ImageUrl { get; set; }

    }
}
