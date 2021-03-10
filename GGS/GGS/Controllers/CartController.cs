using GGS.Data;
using GGS.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using GGS.Web.Models;

namespace GGS.Web.Controllers
{

    public class CartController : Controller
    {
        private ISession _session;
        private readonly ILogger<CartController> _logger;
        private readonly ApplicationDbContext _context;

        public CartController(ILogger<CartController> logger, ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _context = context;
            this._session = httpContextAccessor.HttpContext.Session;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = GetCart(),
                ReturnUrl = returnUrl
            });
        }

        public RedirectToRouteResult AddToCart(int gameId, string returnUrl)
        {
            Game game = _context.Games
                .FirstOrDefault(g => g.ID == gameId);

            if (game != null)
            {
                GetCart().AddItem(game, 1);
            }
            return RedirectToRoute("Index", new { returnUrl });
        }

        public RedirectToRouteResult RemoveFromCart(int gameId, string returnUrl)
        {
            Game game = _context.Games
                .FirstOrDefault(g => g.ID == gameId);

            if (game != null)
            {
                GetCart().RemoveLine(game);
            }
            return RedirectToRoute("Index", new { returnUrl });
        }

        public Cart GetCart()
        {
            Cart cart;
            cart = new Cart();
            /*
            _session.Set("Cart",cart);
            if (cart == null)
            {
                cart = new Cart();
                
                
            }*/
            return cart;
        }
    }
}
