using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_MVC_Test.Models.ViewModels
{
    public class AppointmentsViewModel
    {
        public PagingInfo PagingInfo { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
