using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_MVC_Test.Areas.Client.Controllers
{
	[Area("Client")]
	public class ClientHomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
