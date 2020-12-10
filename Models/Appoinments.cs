using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace doan_webfix.Models
{
    public class Appoinments
    {
        public int Id { get; set; }
        [Display(Name = "Sale Person")]
        public string SalePersonId { get; set; }
        [ForeignKey("SalePersonId")]
        public virtual ApplicationUser SalePerson{get;set;}
        public DateTime AppoinmentDate { get; set; }
        public DateTime AppointmentTime { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }
        [Display(Name="Total")]
        public int TotalAppointment { get; set; }
        public bool isConfirmed { get; set; }
        public string status { get; set; }
    }
}
