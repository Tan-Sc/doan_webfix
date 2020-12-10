using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace doan_webfix.Models.ViewModel
{
    public class AppointmentViewModel
    {
        public List<Appoinments> Appointments { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
