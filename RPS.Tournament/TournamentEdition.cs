using System.Collections.Generic;
using System.Linq;

using RPS.Game;

namespace RPS.Tournament
{
    public class TournamentEdition
    {
        public List<Player> Participants { get; set; }

        public Player Play()
        {
            while (Participants.Count > 1)
            {
                var round = new Round { Participants = Participants };

                Participants = round.Play();
            }

            return Participants.Single();
        }
    }
}
