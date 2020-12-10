using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace doan_webfix.Models.ViewModel
{
    public class ProductViewPage
    {
        public List<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
