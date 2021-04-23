using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_MVC_Test.Controllers
{
    public class ErrorController : Controller
    {
        [Route("404")]
        public IActionResult NotFound404()
        {
            return View();
        }
    }
}
