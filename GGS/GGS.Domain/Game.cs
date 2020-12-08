using System;
using System.Collections.Generic;

namespace GGS.Domain
{
    public class Game
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string ShortDesc { get; set; }

        public string Description { get; set; }

        public int PriceRub { get; set; }

        public string ImageURL { get; set; }

        public IList<Category> Categories { get; set; }

    }
}
