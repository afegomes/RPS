using System.Collections.Generic;
using RPS.Game.Validation;
using Xunit;

namespace RPS.Test
{
    public class EnrollmentValidatorTest
    {
        private readonly EnrollmentValidator _validator;

        public EnrollmentValidatorTest()
        {
            _validator = new EnrollmentValidator();
        }

        [Fact]
        public void GivenAPlayerWithJustOneAtributeWhenValidatedThenShouldThrowAnException()
        {
            var players = new List<List<string>>
            {
                new List<string> {"Player1", "P"},
                new List<string> {"Player2"}
            };

            Assert.Throws<InvalidEnrollmentException>(() => _validator.Validate(players));
        }

        [Fact]
        public void GivenAPlayerWithBothAttributesWhenValidatedThenShouldBeApproved()
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