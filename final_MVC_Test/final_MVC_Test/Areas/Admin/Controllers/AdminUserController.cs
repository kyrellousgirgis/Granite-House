using final_MVC_Test.Data;
using final_MVC_Test.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_MVC_Test.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(Roles =SD.SuperAdminEndUser+","+SD.AdminEndUser)]
	public class AdminUserController : Controller
	{
		private readonly ApplicationDbContext db;

		public AdminUserController(ApplicationDbContext db)
		{
			this.db = db;
		}
		// GET: ApplicationUserController
		public ActionResult Index()
		{
			return View(db.ApplicationUser.ToList());

		}

        #region notNeededToo
        // GET: ApplicationUserController/Details/5
        //public ActionResult Details(string id)
        //{
        //	var userFromDb = db.ApplicationUser.Find(id);
        //	return View(userFromDb);
        //} 
        #endregion

        #region createNotNeeded
        // GET: ApplicationUserController/Create
        //public ActionResult Create()
        //{
        //	return View();
        //}

        //// POST: ApplicationUserController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //	try
        //	{
        //		return RedirectToAction(nameof(Index));
        //	}
        //	catch
        //	{
        //		return View();
        //	}
        //} 
        #endregion

        // GET: ApplicationUserController/Edit/5
        public ActionResult Edit(string id)
		{
			var userFromDb = db.ApplicationUser.Find(id);
			return View(userFromDb);
		}

		// POST: ApplicationUserController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(string id, ApplicationUser collection)
		{
			try
			{

				//db.Entry<ApplicationUser>(collection).State = EntityState.Modified;
				var userFromDb = db.ApplicationUser.Find(id);
				userFromDb.Name = collection.Name;
				userFromDb.Email = collection.Email;
				userFromDb.PhoneNumber = collection.PhoneNumber;
				db.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: ApplicationUserController/Delete/5
		public async  Task<ActionResult> Delete(string id)
		{
			if (id == null || id.Trim().Length == 0)
				return NotFound();

			var userFromDb = await db.ApplicationUser.FindAsync(id);
			if (userFromDb == null)
				return NotFound();
			return View(userFromDb);
		}

		// POST: ApplicationUserController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(string id, IFormCollection collection)
		{
			try
			{
				ApplicationUser userFromDb = db.ApplicationUser.Where(u => u.Id == id).FirstOrDefault();
				//userFromDb.LockoutEnd = DateTime.Now.AddYears(1000);

				db.Remove(userFromDb);
				db.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
