﻿using GGS.Data;
using GGS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace GGS.Controllers
{
    public class HomeController : Controller
    {


        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult Main(string categoryN)
        {
            /* int CurrCategoryID = 2;
             string _categoryN = "Action";
                     var games = _context.Games.Include(x => x.Categories)
                         .Where(x => x.ID == CurrCategoryID)
                         .ToList();
                     return View(games); */

            /*  var games = _context.Games
                  .Include(x => x.Categories.Select(y => y.Games))
                  .Where(x => x.ID == 1)
                  .ToList();
              return View(games);*/

            /* var games = _context.Games.ToList();
             foreach (var game in games)
             {
                 var category = game.Categories

                     .Where(x => x.ID == 1)
                     .ToList();

             }*/
            /*if (categoryN == "Action")
            {
                var games = _context.Games.Where(x => x.Categories.Any(y => y.ID == 1)).ToList();
                return View(games);
            } else if (categoryN == "Shooter")
            {
                var games = _context.Games.Where(x => x.Categories.Any(y => y.ID == 2)).ToList();
                return View(games);
            }   else
            {
                var games = _context.Games.ToList();
                return View(games);
            }*/


            var game = _context.Games.ToList();
            return View(game);




        }

        [Route("Home/ShopPage/{gameId}")]
        public ViewResult ShopPage(int gameId)
        {
            var game = _context.Games
                .FirstOrDefault(x => x.ID == gameId);
            return View(game);
        }
        public ViewResult ShopCart()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
