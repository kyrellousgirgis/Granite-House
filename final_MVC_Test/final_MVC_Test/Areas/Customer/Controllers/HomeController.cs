using final_MVC_Test.Data;
using final_MVC_Test.Extensions;
using final_MVC_Test.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace final_MVC_Test.Areas.Customer.Controllers
{
	[Area("Customer")]
	public class  HomeController : Controller
	{
		private readonly ILogger< HomeController> _logger;
        private readonly ApplicationDbContext db;

        public  HomeController(ILogger< HomeController> logger , ApplicationDbContext db)
		{
			_logger = logger;
            this.db = db;
        }

		public async Task<IActionResult> Index(String name = "")
		{
			//int x = 0;
			//int s = 5 / x;
			if (name == null)
					name = "";
				var applicationDbContext = db.Products.Where(p => p.Name.Contains(name)).Include(p => p.ProductType).Include(p => p.SpecialTag);
			return View(await applicationDbContext.ToListAsync());
		}
		[Authorize(Roles = SD.User+","+SD.SuperAdminEndUser+","+SD.AdminEndUser)]
		public IActionResult Details(int id) {

			Product product = db.Products.Include(p=>p.SpecialTag).Include(p=>p.ProductType).FirstOrDefault(p => p.Id == id);
			return View(product);
		}		
		[HttpPost, ActionName("Details")] 
		[ValidateAntiForgeryToken]
		public IActionResult DetailsPost(int id) {
			List<int> CardItemsIds = HttpContext.Session.Get<List<int>>("shoppingCart");
			if(CardItemsIds is null)
            {
				CardItemsIds = new List<int>();
            }

			CardItemsIds.Add(id);
			HttpContext.Session.Set("shoppingCart", CardItemsIds);

			return RedirectToAction("Index","Home",new { area="Customer" });
		}	
		
		[HttpPost] 
		[ValidateAntiForgeryToken]
		public IActionResult Remove(int id) {
			List<int> CardItemsIds = HttpContext.Session.Get<List<int>>("shoppingCart");
			if(CardItemsIds is null)
            {
				CardItemsIds = new List<int>();
            }
			CardItemsIds.Remove(id);
			HttpContext.Session.Set("shoppingCart", CardItemsIds);

			return RedirectToAction("Index","Home",new { area="Customer" });
		}	

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}


	}
}
