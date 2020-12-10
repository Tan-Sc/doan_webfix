using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace doan_webfix.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Sales Person")]
        public string Name { get; set; }
        [Display(Name="Address")]
        public string Address { get; set; }

        [NotMapped] // khong add thuoc tinh nay vao database
        public bool IsSuperAdmin { get; set; }
        [NotMapped]
        public bool IsCustomerEndUser { get; set; }
        [NotMapped]
        public bool IsAdmin { get; set; }
    }
}
