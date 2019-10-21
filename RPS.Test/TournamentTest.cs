using System.Collections.Generic;
using Xunit;

using RPS.Game;
using RPS.Tournament;

namespace RPS.Test
{
    public class TournamentEditionTest
    {
        private readonly TournamentEdition _tournament;

        public TournamentEditionTest()
        {
            _tournament = new TournamentEdition();
        }

        [Fact]
        public void GivenATournamentWith4ContestantsWhenTheyreDonePlayingThenThereShouldBeOnlyASingleWinner()
        {
            _tournament.Participants = new List<Player>
            {
                new Player
                {
                    Name = "Player1",
                    FavoriteStrategy = Strategy.Rock
                },
                new Player
                {
                    Name = "Player2",
                    FavoriteStrategy = Strategy.Scissors
                },
                new Player
                {
                    Name = "Player3",
                    FavoriteStrategy = Strategy.Paper
                },
                new Player
                {
                    Name = "Player4",
                    FavoriteStrategy = Strategy.Paper
                }
            };

            var winner = _tournament.Play();

            Assert.Equal("Player3", winner.Name);
        }
    }
}
