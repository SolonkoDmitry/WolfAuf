using GGS.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GGS.Web.Controllers
{
    public class AdminController : Controller
    {


        private readonly ILogger<AdminController> _logger;
        private readonly ApplicationDbContext _context;

        public AdminController(ILogger<AdminController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [Authorize(Roles = "Admin")]
        [Route("Admin/Edit/{gameId}")]
        public ViewResult Edit(int gameId)
        {
            var game = _context.Games
                .FirstOrDefault(x => x.ID == gameId);
            return View(game);
        }


        [Authorize]
        [Route("Admin")]
        public IActionResult GamesList()
        {

            var games = _context.Games.ToList();
            return View(games);
        }



    }
}
