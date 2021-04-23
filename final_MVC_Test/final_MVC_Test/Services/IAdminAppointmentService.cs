using final_MVC_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_MVC_Test.Services
{
    interface IAdminAppointmentService
    {
        public void Create(Appointment appointment );
        public void Remove(Appointment appointment );
        public void Edit(int id ,Appointment appointment );
        public void GetAll();
        public void GetByName(string name);
        public void GetById(int id);
    }
}
