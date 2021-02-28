using GGS.Data;
using GGS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GGS.Web.Controllers
{
    public class GamesController : Controller
    {
        private readonly ILogger<GamesController> _logger;
        private readonly ApplicationDbContext _context;

        public GamesController(ILogger<GamesController> logger, ApplicationDbContext context)
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


        [Route("Games/List")]
        [Route("Games/List/{categoryN}")]
        public IActionResult List(string categoryN)
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

            string _category = categoryN;
            if (string.IsNullOrEmpty(categoryN))
            {
                var games = _context.Games.ToList();
                return View(games);
            }
            else
            {

                //CATEGORIES

                if (string.Equals("Action", categoryN, StringComparison.OrdinalIgnoreCase))
                {
                    var games = _context.Games.Where(x => x.Categories.Any(y => y.Name == "Action")).ToList();
                    return View(games);
                }
                else if (string.Equals("Shooter", categoryN, StringComparison.OrdinalIgnoreCase))
                {
                    var games = _context.Games.Where(x => x.Categories.Any(y => y.ID == 2)).ToList();
                    return View(games);
                }
                else if (string.Equals("Adventure", categoryN, StringComparison.OrdinalIgnoreCase))
                {
                    var games = _context.Games.Where(x => x.Categories.Any(y => y.ID == 3)).ToList();
                    return View(games);
                }
                else if (string.Equals("RP", categoryN, StringComparison.OrdinalIgnoreCase))
                {
                    var games = _context.Games.Where(x => x.Categories.Any(y => y.ID == 4)).ToList();
                    return View(games);
                }
                else if (string.Equals("Indi", categoryN, StringComparison.OrdinalIgnoreCase))
                {
                    var games = _context.Games.Where(x => x.Categories.Any(y => y.ID == 5)).ToList();
                    return View(games);
                }
                else if (string.Equals("Simulator", categoryN, StringComparison.OrdinalIgnoreCase))
                {
                    var games = _context.Games.Where(x => x.Categories.Any(y => y.ID == 6)).ToList();
                    return View(games);
                }
                else if (string.Equals("Strategy", categoryN, StringComparison.OrdinalIgnoreCase))
                {
                    var games = _context.Games.Where(x => x.Categories.Any(y => y.ID == 7)).ToList();
                    return View(games);
                }
                else if (string.Equals("Arcade", categoryN, StringComparison.OrdinalIgnoreCase))
                {
                    var games = _context.Games.Where(x => x.Categories.Any(y => y.ID == 8)).ToList();
                    return View(games);
                }
                else if (string.Equals("Sport", categoryN, StringComparison.OrdinalIgnoreCase))
                {
                    var games = _context.Games.Where(x => x.Categories.Any(y => y.ID == 9)).ToList();
                    return View(games);
                }
                else if (string.Equals("Casual", categoryN, StringComparison.OrdinalIgnoreCase))
                {
                    var games = _context.Games.Where(x => x.Categories.Any(y => y.ID == 10)).ToList();
                    return View(games);
                }
                else if (string.Equals("Horror", categoryN, StringComparison.OrdinalIgnoreCase))
                {
                    var games = _context.Games.Where(x => x.Categories.Any(y => y.ID == 11)).ToList();
                    return View(games);
                }
                else if (string.Equals("Survival", categoryN, StringComparison.OrdinalIgnoreCase))
                {
                    var games = _context.Games.Where(x => x.Categories.Any(y => y.ID == 12)).ToList();
                    return View(games);
                }
                else if (string.Equals("OpenWorld", categoryN, StringComparison.OrdinalIgnoreCase))
                {
                    var games = _context.Games.Where(x => x.Categories.Any(y => y.ID == 13)).ToList();
                    return View(games);
                }
                else if (string.Equals("Plot", categoryN, StringComparison.OrdinalIgnoreCase))
                {
                    var games = _context.Games.Where(x => x.Categories.Any(y => y.ID == 14)).ToList();
                    return View(games);
                }



                //SECTIONS

                else if (string.Equals("Steam", categoryN, StringComparison.OrdinalIgnoreCase))
                {
                    var games = _context.Games.Where(x => x.Categories.Any(y => y.ID == 15)).ToList();
                    return View(games);
                }
                else if (string.Equals("Origin", categoryN, StringComparison.OrdinalIgnoreCase))
                {
                    var games = _context.Games.Where(x => x.Categories.Any(y => y.ID == 16)).ToList();
                    return View(games);
                }
                else if (string.Equals("UPlay", categoryN, StringComparison.OrdinalIgnoreCase))
                {
                    var games = _context.Games.Where(x => x.Categories.Any(y => y.ID == 17)).ToList();
                    return View(games);
                }
                else if (string.Equals("Battle.net", categoryN, StringComparison.OrdinalIgnoreCase))
                {
                    var games = _context.Games.Where(x => x.Categories.Any(y => y.ID == 18)).ToList();
                    return View(games);
                }
                else if (string.Equals("Xbox", categoryN, StringComparison.OrdinalIgnoreCase))
                {
                    var games = _context.Games.Where(x => x.Categories.Any(y => y.ID == 19)).ToList();
                    return View(games);
                }
                else if (string.Equals("Playstation", categoryN, StringComparison.OrdinalIgnoreCase))
                {
                    var games = _context.Games.Where(x => x.Categories.Any(y => y.ID == 20)).ToList();
                    return View(games);
                }
                else if (string.Equals("MacOsX", categoryN, StringComparison.OrdinalIgnoreCase))
                {
                    var games = _context.Games.Where(x => x.Categories.Any(y => y.ID == 21)).ToList();
                    return View(games);
                }
                else if (string.Equals("Linux+SteamOS", categoryN, StringComparison.OrdinalIgnoreCase))
                {
                    var games = _context.Games.Where(x => x.Categories.Any(y => y.ID == 22)).ToList();
                    return View(games);
                }
                else
                {
                    var game = _context.Games.ToList();
                    return View(game);
                }

            }

        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
