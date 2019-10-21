using System.Collections.Generic;
using RPS.Game.Validation;
using Xunit;

namespace RPS.Test
{
    public class StrategyValidatorTest
    {
        private readonly StrategyValidator _validator;

        public StrategyValidatorTest()
        {
            _validator = new StrategyValidator();
        }

        [Fact]
        public void GivenAPlayerWithAnInvalidStrategyWhenValidatedThenShouldThrowAnException()
        {
            var players = new List<List<string>>
            {
                new List<string> {"Player1", "X"},
                new List<string> {"Player2", "R"}
            };

            Assert.Throws<NoSuchStrategyError>(() => _validator.Validate(players));
        }

        [Fact]
        public void GivenAPlayerWithAValidStrategyWhenValidatedThenShouldBeApproved()
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