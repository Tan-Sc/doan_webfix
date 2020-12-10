using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace doan_webfix.Models
{
    public class ProductType
    {
        public int ProductTypeId { get; set; }
        
        [Required]
        public string ProductTypeName { get; set; }
    }
}
