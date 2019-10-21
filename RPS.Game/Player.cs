namespace RPS.Game
{
    public class Player
    {
        public string Name { get; set; }

        public Strategy FavoriteStrategy { get; set; }

        public Player Challenge(Player adversary)
        {
            return FavoriteStrategy.Equals(adversary.FavoriteStrategy) || FavoriteStrategy.Beats(adversary.FavoriteStrategy) ? this : adversary;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }

            var player = (Player)obj;

            return Name.Equals(player.Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
