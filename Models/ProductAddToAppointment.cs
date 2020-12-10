using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace doan_webfix.Models
{
    public class ProductAddToAppointment
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        [ForeignKey("AppointmentId")]
        public  virtual Appoinments Appointments { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Products { get; set; }
        public int Count { get; set; }

        public int Total { get; set; }
    }
}
