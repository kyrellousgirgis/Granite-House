using final_MVC_Test.Data;
using final_MVC_Test.Models;
using final_MVC_Test.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_MVC_Test.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.SuperAdminEndUser + "," + SD.AdminEndUser)]
    public class AppointmentController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<IdentityUser> userManager;
        int pageSize = 3;
        public AppointmentController(ApplicationDbContext db, UserManager<IdentityUser> _userManager)
        {

            this.db = db;
            userManager = _userManager;
        }
        // GET: AppointmentController
        public async Task<ActionResult> Index( string searchName = null, string searchEmail = null
            , string searchPhone = null, string searchDate = null,int productPage = 1)
        {
            AppointmentsViewModel appointmentsVM = new() {
                Appointments = db.Appointments.ToList()
            };
            if(searchName is not null)
            {
                appointmentsVM.Appointments = appointmentsVM.Appointments
                    .Where(a => a.CustomerName.ToLower().Contains(searchName.ToLower())).ToList();
            }
          
            if(searchDate is not null)
            {
                DateTime dateTime = Convert.ToDateTime(searchDate);

                appointmentsVM.Appointments = appointmentsVM.Appointments
                    .Where(a => a.AppointmentDate.ToShortDateString().Equals(dateTime.ToShortDateString())).ToList();
            }

            if (searchPhone is not null)
            {
                appointmentsVM.Appointments = appointmentsVM.Appointments
                    .Where(a => a.CustomerPhoneNumber.Contains(searchPhone)).ToList();
            }

            if (searchEmail is not null)
            {
                appointmentsVM.Appointments = appointmentsVM.Appointments
                    .Where(a => a.CustomerEmail.ToLower().Contains(searchEmail.ToLower())).ToList();
            }
            int count = appointmentsVM.Appointments.Count;
            appointmentsVM.Appointments = appointmentsVM.Appointments.Skip((productPage-1)*pageSize)
                .Take(pageSize).ToList();
            appointmentsVM.PagingInfo = new()
            {
                CurrentPage = productPage,
                TotalItems = count,
                ItemsPerPage = pageSize,
            };
            return View(appointmentsVM);
        }

        // GET: AppointmentController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return  NotFound();

            var AppointmentProducts = db.ProductsSelectedForAppointments
                .Where(ap => ap.AppointmentId == id)
                .Include(ap => ap.Products).ThenInclude(p => p.ProductType)
                .Select(ap => ap.Products).ToList();


            //var AppointmentProducts = (from p in db.Products
            //                           join ap in db.ProductsSelectedForAppointments
            //                           on p.Id equals ap.ProductId
            //                           where ap.AppointmentId == id
            //                           select p).Include(product => product.ProductType).ToList();

            AppointmentDetailsViewModel objAppointmentVM = new AppointmentDetailsViewModel()
            {
                Appointment = db.Appointments.Include(a => a.SalesPerson).FirstOrDefault(a => a.Id == id),
                SalesPerson = db.ApplicationUser.ToList(),
                Products = AppointmentProducts.ToList()
            };

            return View(objAppointmentVM);
        }

        #region Create Get
        // GET: AppointmentController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //} 
        #endregion

        #region Create Post
        //// POST: AppointmentController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //} 
        #endregion

        // GET: AppointmentController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {

            if (id == null)
                return NotFound();

            var AppointmentProducts = db.ProductsSelectedForAppointments
                .Where(ap => ap.AppointmentId == id)
                .Include(ap => ap.Products).ThenInclude(p => p.ProductType)
                .Select(ap => ap.Products).ToList();
            var users = db.ApplicationUser.ToList();
            List<ApplicationUser> salesPersons = new List<ApplicationUser>();
            foreach (var item in users)
            {
                if(await userManager.IsInRoleAsync(item, SD.AdminEndUser))
                {
                    salesPersons.Add(item);
                }
            }

            AppointmentDetailsViewModel objAppointmentVM = new AppointmentDetailsViewModel()
            {
                Appointment = db.Appointments.Include(a => a.SalesPerson).FirstOrDefault(a => a.Id == id),
                SalesPerson = salesPersons,
                //SalesPerson = db.ApplicationUser.ToList(),
                Products = AppointmentProducts.ToList()
            };

            return View(objAppointmentVM);
        }

        //bool IsAdmin(IdentityUser usr)
        //{
        //    var isAdmin =  userManager.IsInRoleAsync(usr, SD.AdminEndUser).Result;
        //    return isAdmin;
        //}
        // POST: AppointmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, AppointmentDetailsViewModel appointmentvm)
        {
            //try
            //{


            //}
            //catch
            //{
            //    return View();
            //}


            if(ModelState.IsValid)
			{
                appointmentvm.Appointment.AppointmentDate = appointmentvm.Appointment.AppointmentDate
                   .AddHours(appointmentvm.Appointment.AppointmentTime.Hour)
                   .AddMinutes(appointmentvm.Appointment.AppointmentTime.Minute);


                //var appointmentFromDb = db.Appointments.Where(a => a.Id == appointmentvm.Appointment.Id).FirstOrDefault();


                //appointmentFromDb.CustomerName = appointmentvm.Appointment.CustomerName;
                //appointmentFromDb.CustomerEmail = appointmentvm.Appointment.CustomerEmail;
                //appointmentFromDb.CustomerPhoneNumber = appointmentvm.Appointment.CustomerPhoneNumber;
                //appointmentFromDb.AppointmentDate = appointmentvm.Appointment.AppointmentDate;
                //appointmentFromDb.isConfirmed = appointmentvm.Appointment.isConfirmed;
                ////if (User.IsInRole(SD.SuperAdminEndUser))
                ////{
                //    appointmentFromDb.SalesPersonId = appointmentvm.Appointment.SalesPersonId;
                //}

                db.Entry<Appointment>(appointmentvm.Appointment).State = EntityState.Modified; 
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
			}
            return View(appointmentvm);

        }

        // GET: AppointmentController/Delete/5
        public ActionResult Delete(int id)
        {

            if (id == null)
                return NotFound();

            var AppointmentProducts = db.ProductsSelectedForAppointments
                .Where(ap => ap.AppointmentId == id)
                .Include(ap => ap.Products).ThenInclude(p => p.ProductType)
                .Select(ap => ap.Products).ToList();


          
            AppointmentDetailsViewModel objAppointmentVM = new AppointmentDetailsViewModel()
            {
                Appointment = db.Appointments.Include(a => a.SalesPerson).FirstOrDefault(a => a.Id == id),
                SalesPerson = db.ApplicationUser.ToList(),
                Products = AppointmentProducts.ToList()
            };

            return View(objAppointmentVM);

        }

        // POST: AppointmentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            //try
            //{
                db.Appointments.Remove(await db.Appointments.FindAsync(id));
               await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            //}
            //catch
            //{
            //    return View();
            //}
        }
    }
}
