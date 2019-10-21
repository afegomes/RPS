using System.Collections.Generic;
using RPS.Game.Validation;
using Xunit;

namespace RPS.Test
{
    public class TotalParticipantsValidatorTest
    {
        private readonly TotalParticipantsValidator _validator;

        public TotalParticipantsValidatorTest()
        {
            _validator = new TotalParticipantsValidator(2);
        }

        [Fact]
        public void GivenAListWithNotEnoughPlayersWhenValidatedThenShouldThrowAnException()
        {
            var players = new List<List<string>>
            {
                new List<string> {"Player1", "P"}
            };

            Assert.Throws<WrongNumberOfPlayersError>(() => _validator.Validate(players));
        }

        [Fact]
        public void GivenAListWithAnExcessOfPlayersWhenValidatedThenShouldThrowAnException()
        {
            var players = new List<List<string>>
            {
                new List<string> {"Player1", "P"},
                new List<string> {"Player2", "R"},
                new List<string> {"Player3", "S"}
            };

            Assert.Throws<WrongNumberOfPlayersError>(() => _validator.Validate(players));
        }

        [Fact]
        public void GivenAListWithTheRightNumberPlayersWhenValidatedThenShouldBeApproved()
        {
            var players = new List<List<string>>
            {
                new List<string> {"Player1", "P"},
                new List<string> {"Player2", "R"}
            };

            _validator.Validate(players);
        }
    }
}
