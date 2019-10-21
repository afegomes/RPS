using RPS.Game;
using Xunit;

namespace RPS.Test
{
    public class PlayerTest
    {
        private readonly Player _player1;
        private readonly Player _player2;

        public PlayerTest()
        {
            _player1 = new Player { Name = "Player1" };
            _player2 = new Player { Name = "Player2" };
        }

        [Fact]
        public void GivenAPlayerWithAPairOfScissorsWhenHeChallengesAPlayerWithAPieceOfPaperThenTheFormerShouldBeVictorious()
        {
            _player1.FavoriteStrategy = Strategy.Scissors;
            _player2.FavoriteStrategy = Strategy.Paper;

            var winner = _player1.Challenge(_player2);

            Assert.Equal(_player1, winner);
        }

        [Fact]
        public void GivenAPlayerWithAPairOfScissorsWhenHeChallengesAPlayerWithAChunkOfRockThenTheLatterShouldBeVictorious()
        {
            _player1.FavoriteStrategy = Strategy.Scissors;
            _player2.FavoriteStrategy = Strategy.Rock;

            var winner = _player1.Challenge(_player2);

            Assert.Equal(_player2, winner);
        }

        [Fact]
        public void GivenAPlayerWithAPieceOfPaperWhenHeChallengesAPlayerWithAChunkOfRockThenTheFormerShouldBeVictorious()
        {
            _player1.FavoriteStrategy = Strategy.Paper;
            _player2.FavoriteStrategy = Strategy.Rock;

            var winner = _player1.Challenge(_player2);

            Assert.Equal(_player1, winner);
        }

        [Fact]
        public void GivenAPlayerWithAPairOfScissorsWhenHeChallengesAPlayerWithAnotherPairOfScissorsThenTheFormerShouldBeVictorious()
        {
            _player1.FavoriteStrategy = Strategy.Scissors;
            _player2.FavoriteStrategy = Strategy.Scissors;

            var winner = _player1.Challenge(_player2);

            Assert.Equal(_player1, winner);
        }

        [Fact]
        public void GivenAPlayerWithAPieceOfPaperWhenHeChallengesAPlayerWithAnotherPieceOfPaperThenTheFormerShouldBeVictorious()
        {
            _player1.FavoriteStrategy = Strategy.Paper;
            _player2.FavoriteStrategy = Strategy.Paper;

            var winner = _player1.Challenge(_player2);

            Assert.Equal(_player1, winner);
        }

        [Fact]
        public void GivenAPlayerWithAChunkOfRockWhenHeChallengesAPlayerWithAnotherChunkOfRockThenTheFormerShouldBeVictorious()
        {
            _player1.FavoriteStrategy = Strategy.Rock;
            _player2.FavoriteStrategy = Strategy.Rock;

            var winner = _player1.Challenge(_player2);

            Assert.Equal(_player1, winner);
        }
    }
}
