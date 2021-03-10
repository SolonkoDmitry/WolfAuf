using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace GGS.Domain
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();


        public void AddItem(Game game, int quantity)
        {
            CartLine line = lineCollection
                .Where(g => g.Game.ID == game.ID)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Game = game,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(Game game)
        {
            lineCollection.RemoveAll(l => l.Game.ID == game.ID);
        }

        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.Game.PriceRub * e.Quantity);

        }
        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }
    }

    public class CartLine
    {
        public Game Game { get; set; }
        public int Quantity { get; set; }
    }


}