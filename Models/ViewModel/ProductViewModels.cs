using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace doan_webfix.Models.ViewModel
{
    public class ProductViewModels
    {
        public Product Products { get; set; }
        public IEnumerable<ProductType> ProductTypes { get; set; }
    }
}
