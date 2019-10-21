using System.Linq;

namespace RPS.Game
{
    public class Strategy
    {
        public static readonly Strategy Rock = new Strategy('R', "a chunk of rock", 'P');
        public static readonly Strategy Paper = new Strategy('P', "a piece of paper", 'S');
        public static readonly Strategy Scissors = new Strategy('S', "a pair of scissors", 'R');
        public static readonly Strategy[] All = { Rock, Paper, Scissors };

        public static Strategy ForIdentifier(char identifier)
        {
            return All.Where(s => s.Identifier.Equals(identifier)).Single();
        }

        private Strategy(char identifier, string description, char nemesis)
        {
            Identifier = identifier;
            Description = description;
            Nemesis = nemesis;
        }

        public char Identifier { get; private set; }

        public string Description { get; private set; }

        public char Nemesis { get; private set; }

        public bool Beats(Strategy other)
        {
            return Identifier.Equals(other.Nemesis);
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }

            var strategy = (Strategy)obj;

            return Description.Equals(strategy.Description);
        }

        public override int GetHashCode()
        {
            return Description.GetHashCode();
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
