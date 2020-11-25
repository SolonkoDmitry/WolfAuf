using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GGS.Models;
using GGS.Data;
using System.Diagnostics;

namespace GGS.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyAppContext _context;

        public HomeController(ILogger<HomeController> logger, MyAppContext context)
        {
            _logger = logger;
            _context = context;
        }
        public ActionResult Main()
        {
            
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

    }
}
