using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace doan_webfix.Models.ViewModel
{
    public class ShoppingCartViewModel
    {

        public List<CartItem> cartItems { get; set; }
        public ApplicationUser customer { get; set; }
        public Appoinments Appoinments { get; set; }
        public int TotalApointment { get; set; }

    }
}
