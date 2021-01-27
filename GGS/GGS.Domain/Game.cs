using System;
using System.Collections.Generic;

namespace GGS.Domain
{
    public class Game
    {
        public Game(int iD, string name, string shortDesc, string description, int priceRub, string imageURL)
        {
            ID = iD;
            Name = name;
            ShortDesc = shortDesc;
            Description = description;
            PriceRub = priceRub;
            ImageURL = imageURL;
        }

        public int ID { get; protected set; }

        public string Name { get; protected set; }

        public string ShortDesc { get; protected set; }

        public string Description { get; protected set; }

        public int PriceRub { get; protected set; }

        public string ImageURL { get; protected set; }

        public IList<Category> Categories { get; protected set; }

        public IList<Section> Sections { get; protected set; }
    }
}
