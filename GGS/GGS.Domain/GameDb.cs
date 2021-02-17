using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGS.Domain
{
    public interface GameDb
    {
        IEnumerable<Game> Games { get; }
        void SaveGame(Game game);
    }
}
