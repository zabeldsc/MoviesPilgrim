using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MoviesPilgrim.Controllers
{
    [Route("api/[controller]/[action]")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult ViewAll()
        {
            return View();
        }
        
        public IActionResult Error()
        {
            return View("Error!");
        }

    }
}