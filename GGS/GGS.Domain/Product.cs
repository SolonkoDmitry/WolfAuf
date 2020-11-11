using System;
using System.Collections;
using System.Collections.Generic;

namespace GGS.Domain
{
    public class Product
    {
        protected Product()
        {
        }

        public Product(int iD, string name, 
            string description, decimal priceRub, string imageURL)
        {
            ID = iD;
            Name = name;
            Description = description;
            PriceRub = priceRub;
            ImageURL = imageURL;
        }


        public int ID { get; protected set; }

        public string Name { get; protected set; }

        public string Description { get; protected set; }

        public decimal PriceRub { get; protected set; }

        public string ImageURL { get; protected set; }

        public IList<Category> Categories { get; protected set; }
    }
}
