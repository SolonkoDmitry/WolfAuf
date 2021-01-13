using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGS.Domain
{
    public class Section
    {
        
        public int ID { get; protected set; }

        public string Name { get; protected set; }

        public IList<Game> Games { get; protected set; }
    }
}
