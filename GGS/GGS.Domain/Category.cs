using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGS.Domain
{
    public class Category
    {

        public int ID { get; protected set; }

        public string Name { get; protected set; }

        public Category(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        protected Category()
        {
        }

        
    }
}
