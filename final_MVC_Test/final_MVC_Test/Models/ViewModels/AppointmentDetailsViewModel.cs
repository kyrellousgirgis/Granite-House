using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_MVC_Test.Models.ViewModels
{
    public class AppointmentDetailsViewModel
    {
        public Appointment Appointment { get; set; }
        public List<ApplicationUser> SalesPerson { get; set; }

        public List<Product> Products { get; set; }
    }
}
