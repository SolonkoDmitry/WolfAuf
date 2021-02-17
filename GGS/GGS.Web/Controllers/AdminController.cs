using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using GGS.Data;
using GGS.Domain;
using GGS.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GGS.Web.Controllers
{
    public class AdminController : Controller
    {


        private readonly ILogger<AdminController> _logger;
        private readonly MyAppContext _context;

        public AdminController(ILogger<AdminController> logger, MyAppContext context)
        {
            _logger = logger;
            _context = context;
        }


        [Route("Admin/Edit/{gameId}")]
        public ViewResult Edit(int gameId)
        {
            var game = _context.Games
                .FirstOrDefault(x => x.ID == gameId);
            return View(game);
        }



        public IActionResult GamesList()
        {

            var games = _context.Games.ToList();
            return View(games);
        }



    }
}
