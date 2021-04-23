using final_MVC_Test.Data;
using final_MVC_Test.Extensions;
using final_MVC_Test.Models;
using final_MVC_Test.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_MVC_Test.Areas.Customer.Controllers
{
    

    [Area("Customer")]
    public class ShoppingCartController : Controller
    {
 
        private readonly ApplicationDbContext db;
        private readonly UserManager<IdentityUser> userManager;

        [BindProperty]
        public ShoppingCartViewModel shoppingCartViewModel { get; set; }


        public ShoppingCartController(ApplicationDbContext db,UserManager<IdentityUser> userManager)
        {
            shoppingCartViewModel = new ShoppingCartViewModel()
            {
                //Appointment = new Appointment(),
                Products = new List<Models.Product>()
            };
            this.db = db;
            this.userManager = userManager;
        }
        // GET: ShoppingCartController1
        public async  Task<ActionResult> Index()
        {
            List<int> ProductItemsIds = HttpContext.Session.Get<List<int>>("shoppingCart");
            if (ProductItemsIds != null && ProductItemsIds.Count > 0 )
            {
                shoppingCartViewModel.Products =await db.Products.Where(p=>ProductItemsIds.Contains(p.Id)).Include(p=>p.ProductType).Include(p=>p.SpecialTag).ToListAsync();
            }
            


            return View(shoppingCartViewModel);
        }
        [HttpPost, ActionName("Index")]

        [ValidateAntiForgeryToken]
        public async  Task<ActionResult> IndexPost()
        {
            if (ModelState.IsValid)
            {
                var usr = userManager.FindByNameAsync("SuperAdmin@gmail.com").Result;
                shoppingCartViewModel.Appointment.SalesPersonId = usr.Id;
                List<int> lstCartItems = HttpContext.Session.Get<List<int>>("shoppingCart");
                db.Appointments.Add(shoppingCartViewModel.Appointment);
               await db.SaveChangesAsync();
               var appointmentId = shoppingCartViewModel.Appointment.Id;
                foreach (int productId in lstCartItems)
                {
                    ProductsSelectedForAppointment productsSelectedForAppointment = new ProductsSelectedForAppointment()
                    {
                        AppointmentId = appointmentId,
                        ProductId = productId
                    };
                    db.ProductsSelectedForAppointments.Add(productsSelectedForAppointment);

                }
                await db.SaveChangesAsync();
                //Charge( stripeEmail,  stripeToken);
                //HttpContext.Session.Set("shoppingCart",new List<int>());
            return RedirectToAction("AppointmentConfirmation","ShoppingCart", new {area ="Customer", Id = shoppingCartViewModel.Appointment.Id });

            }
            return RedirectToAction($"Index", "ShoppingCart", new { area = "Customer"});

        }

        // GET: ShoppingCartController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ShoppingCartController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShoppingCartController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShoppingCartController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShoppingCartController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShoppingCartController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShoppingCartController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Charge()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Charge(string stripeEmail, string stripeToken)
        {
            List<int> ProductItemsIds = HttpContext.Session.Get<List<int>>("shoppingCart");
            if (ProductItemsIds != null && ProductItemsIds.Count > 0)
            {
                shoppingCartViewModel.Products = db.Products.Where(p => ProductItemsIds.Contains(p.Id)).Include(p => p.ProductType).Include(p => p.SpecialTag).ToList();
            }
            double totalprice = 0;
            foreach(var item in shoppingCartViewModel.Products)
            {
                totalprice += item.Price;
            }

            var customers = new CustomerService();
            var charges = new ChargeService();

            var customer = customers.Create(new CustomerCreateOptions
            {
                Email = stripeEmail,
                Source = stripeToken
            });
            var charge = charges.Create(new ChargeCreateOptions
            {
                Amount = (long)totalprice * 100 ,
                Description = "Payment",
                Currency = "USD",
                Customer = customer.Id,
                ReceiptEmail = stripeEmail,
                //Metadata = new Dictionary<string, string>()
                //{
                //any data i want it to be sent to database
                //    //{"OrderId", "111"},
                //    //{ "Postcode", "LEE111" }
                //}
            });


            if (charge.Status == "succeeded")
            {
                string BalanceTransactionId = charge.BalanceTransactionId;
                HttpContext.Session.Set("shoppingCart", new List<int>());
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");

            }
            return RedirectToAction("Index");

        }
        public IActionResult AppointmentConfirmation(int id)
        {
            shoppingCartViewModel.Appointment = db.Appointments.Where(p => p.Id == id).FirstOrDefault();
            List<ProductsSelectedForAppointment> objProdList = db.ProductsSelectedForAppointments
                .Where(p => p.AppointmentId == id).ToList();

            foreach (ProductsSelectedForAppointment prodApp in objProdList)
            {
                var prd = db.Products.Include(p => p.ProductType).Include(p => p.SpecialTag).Where(p => p.Id == prodApp.ProductId).FirstOrDefault();
                shoppingCartViewModel.Products.Add(prd);
            }

            return View(shoppingCartViewModel);
        }

    }
}
