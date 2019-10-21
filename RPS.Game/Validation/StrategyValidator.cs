using System.Collections.Generic;
using System.Linq;

namespace RPS.Game.Validation
{
    public class StrategyValidator : IValidator
    {
        public void Validate(List<List<string>> players)
        {
            var validStrategies = Strategy.All.Select(x => x.Identifier);

            if (players.Any(x => !validStrategies.Contains(x.Last().Single())))
            {
                throw new NoSuchStrategyError();
            }
        }
    }
}
