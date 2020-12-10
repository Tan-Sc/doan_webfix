using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace doan_webfix.Models.ViewModel
{
    public class AppointmentDetailsViewModel
    {

        public Appoinments Appointment { get; set; }
        public List<ApplicationAdminUser> SalesPerson { get; set; }
        public List<CartItem> Products { get; set; }

    }
}
