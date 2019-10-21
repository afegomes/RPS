using System.Collections.Generic;
using System.Linq;

using RPS.Game;

namespace RPS.Tournament
{
    public class Round
    {
        public List<Player> Participants { get; set; }

        public List<Player> Play()
        {
            var qualified = new List<Player>();

            while (Participants.Any())
            {
                var playing = Participants.Take(2).ToArray();
                var player1 = playing[0];
                var player2 = playing[1];

                qualified.Add(player1.Challenge(player2));

                Participants.RemoveRange(0, 2);
            }

            return qualified;
        }
    }
}
