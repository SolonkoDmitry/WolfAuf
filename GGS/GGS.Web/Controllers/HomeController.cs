using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GGS.Web.Models;
using GGS.Data;

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

        public ActionResult Login()
        {
            return View();
        }

        public IActionResult Index()
        {
            var games = _context.Games.ToList();
            return View(games);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Main()
        {
             var games = _context.Games.ToList();
            return View(games);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
