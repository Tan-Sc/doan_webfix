using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace doan_webfix.Models
{
    public class ApplicationCustomerAccount : ApplicationUser
    {
        public static implicit operator ApplicationCustomerAccount(ClaimsPrincipal v)
        {
            throw new NotImplementedException();
        }
    }
}
