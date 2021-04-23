using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace final_MVC_Test.Models
{
    public class ProductsSelectedForAppointment
    {
        public int Id { get; set; }

        public int AppointmentId { get; set; }


        [ForeignKey("AppointmentId")]
        public virtual Appointment Appointments { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Products { get; set; }
    }
}
