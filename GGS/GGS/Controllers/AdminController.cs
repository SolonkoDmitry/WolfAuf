using GGS.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Identity;

namespace GGS.Web.Controllers
{
    public class AdminController : Controller
    {


        private readonly ILogger<AdminController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminController(ILogger<AdminController> logger, ApplicationDbContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        [Authorize(Roles ="admin")]
        [Route("Admin/Edit/{gameId}")]
        public async Task<ViewResult> Edit(int gameId)
        {

            var currentUser = HttpContext.User;

            var userManagerUser = await _userManager.GetUserAsync(currentUser);

            var roles = await _userManager.GetRolesAsync(userManagerUser);

            var xrole =  _roleManager.Roles.ToList();
            var game = _context.Games
                .FirstOrDefault(x => x.ID == gameId);
            return View(game);
        }


        [Authorize(Roles = "admin")]
        [Route("Admin")]
        public IActionResult GamesList()
        {

            var games = _context.Games.ToList();
            return View(games);
        }



    }
}
