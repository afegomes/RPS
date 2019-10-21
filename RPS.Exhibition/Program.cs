using System;
using System.Collections.Generic;
using System.Linq;

using RPS.Game;
using RPS.Game.Validation;

namespace RPS.Exhibtion
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = createPlayerData();
            var winner = rps_game_winner(players);

            Console.WriteLine("{0} won using {1}!", winner.Name, winner.FavoriteStrategy);
        }

        private static Player rps_game_winner(List<List<string>> playerData)
        {
            GetValidators().ForEach(v => v.Validate(playerData));

            var players = new PlayerDataConverter().Convert(playerData);
            var player1 = players.ElementAt(0);
            var player2 = players.ElementAt(1);

            return player1.Challenge(player2);
        }

        private static List<IValidator> GetValidators()
        {
            return new List<IValidator>
            {
                new TotalParticipantsValidator(2),
                new EnrollmentValidator(),
                new StrategyValidator()
            };
        }

        private static List<List<string>> createPlayerData()
        {
            return new List<List<string>>
            {
                new List<string> {"Kano", "P"},
                new List<string> {"Scorpion", "R"}
            };
        }
    }
}
