using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_MVC_Test.Areas.Admin.Controllers
{
	public class AdminHome : Controller
	{
		// GET: AdminHome
		public ActionResult Index()
		{
			return View();
		}


		//// GET: AdminHome/Details/5
		//public ActionResult Details(int id)
		//{
		//	return View();
		//}

		//// GET: AdminHome/Create
		//public ActionResult Create()
		//{
		//	return View();
		//}

		//// POST: AdminHome/Create
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

		//// GET: AdminHome/Edit/5
		//public ActionResult Edit(int id)
		//{
		//	return View();
		//}

		//// POST: AdminHome/Edit/5
		//[HttpPost]
		//[ValidateAntiForgeryToken]
		//public ActionResult Edit(int id, IFormCollection collection)
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

		//// GET: AdminHome/Delete/5
		//public ActionResult Delete(int id)
		//{
		//	return View();
		//}

		//// POST: AdminHome/Delete/5
		//[HttpPost]
		//[ValidateAntiForgeryToken]
		//public ActionResult Delete(int id, IFormCollection collection)
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
	}
}
