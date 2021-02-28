using System;
using System.Collections.Generic;

namespace GGS.Domain
{
    public class Category
    {
        public Category(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public int ID { get; protected set; }

        public string Name { get; protected set; }

        public IList<Game> Games { get; protected set; }

    }
}
