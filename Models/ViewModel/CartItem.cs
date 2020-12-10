using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace doan_webfix.Models.ViewModel
{
    public class CartItem
    {
        public Product itemCart { get; set; }
        public int quantity { get; set; }
        public int totalItem { get; set; }
    }
}
