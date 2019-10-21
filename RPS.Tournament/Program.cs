using System;
using System.Collections.Generic;
using System.Linq;

using RPS.Game;
using RPS.Game.Validation;

namespace RPS.Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            var winner = rps_tournament_winner(createPlayerData());

            Console.WriteLine("{0} won using {1}!", winner.Name, winner.FavoriteStrategy);
        }

        private static Player rps_tournament_winner(List<List<List<List<string>>>> playerData)
        {
            var flattened = playerData.SelectMany(x => x).SelectMany(x => x).ToList();

            GetValidators().ForEach(v => v.Validate(flattened));

            var players = new PlayerDataConverter().Convert(flattened);
            var tournament = new TournamentEdition { Participants = players };

            return tournament.Play();
        }

        private static List<IValidator> GetValidators()
        {
            return new List<IValidator>
            {
                new TotalParticipantsValidator(16),
                new EnrollmentValidator(),
                new StrategyValidator()
            };
        }

        private static List<List<List<List<string>>>> createPlayerData()
        {
            return new List<List<List<List<string>>>>
            {
                new List<List<List<string>>>
                {
                    new List<List<string>>
                    {
                        new List<string> {"Cyrax", "R"},
                        new List<string> {"Nightwolf", "S"}
                    },
                    new List<List<string>>
                    {
                        new List<string> {"Sektor", "P"},
                        new List<string> {"Kabal", "R"}
                    }
                },
                new List<List<List<string>>>
                {
                    new List<List<string>>
                    {
                        new List<string> {"Sonya", "S"},
                        new List<string> {"Sindel", "S"}
                    },
                    new List<List<string>>
                    {
                        new List<string> {"Stryker", "P"},
                        new List<string> {"Sheeva", "S"}
                    }
                },
                new List<List<List<string>>>
                {
                    new List<List<string>>
                    {
                        new List<string> {"Kano", "R"},
                        new List<string> {"Jax", "P"}
                    },
                    new List<List<string>>
                    {
                        new List<string> {"Smoke", "S"},
                        new List<string> {"Motaro", "R"}
                    }
                },
                new List<List<List<string>>>
                {
                    new List<List<string>>
                    {
                        new List<string> {"Kung Lao", "P"},
                        new List<string> {"Liu Kang", "R"}
                    },
                    new List<List<string>>
                    {
                        new List<string> {"Reptile", "S"},
                        new List<string> {"Scorpion", "R"}
                    }
                }
            };
        }
    }
}
