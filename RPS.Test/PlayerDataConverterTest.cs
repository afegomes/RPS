using System.Collections.Generic;
using RPS.Game;
using Xunit;

namespace RPS.Test
{
    public class PlayerDataConverterTest
    {
        private readonly PlayerDataConverter _converter;

        public PlayerDataConverterTest()
        {
            _converter = new PlayerDataConverter();
        }

        [Fact]
        public void GivenAStringListBasedDataStructureWhenConvertedThenItShouldTurnIntoAListOfPlayers()
        {
            var raw = new List<List<string>>
            {
                new List<string> {"Player1", "R"},
                new List<string> {"Player2", "S"}
            };

            var players = _converter.Convert(raw);

            Assert.Equal(2, players.Count);

            Assert.Equal("Player1", players[0].Name);
            Assert.Equal(Strategy.Rock, players[0].FavoriteStrategy);

            Assert.Equal("Player2", players[1].Name);
            Assert.Equal(Strategy.Scissors, players[1].FavoriteStrategy);
        }
    }
}
