using System.Collections.Generic;
using System.Linq;

namespace RPS.Game
{
    public class PlayerDataConverter
    {
        public List<Player> Convert(List<List<string>> data)
        {
            return data.Select(x => new Player { Name = x.ElementAt(0), FavoriteStrategy = Strategy.ForIdentifier(x.ElementAt(1).Single()) }).ToList();
        }
    }
}
