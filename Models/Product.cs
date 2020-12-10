using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace doan_webfix.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int newPrice { get; set; }
        public int Price { get; set;}
        public string Image { get; set; }
        public string Mota { get; set; }
        public int ProductType_Id { get; set; }

        [ForeignKey("ProductType_Id")]
        public virtual ProductType ProductTypes { get; set; }
        public string ProductSize { get; set; }
        public bool isNew { get; set; }

    }
}
