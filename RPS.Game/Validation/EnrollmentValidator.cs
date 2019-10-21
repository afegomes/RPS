using System.Collections.Generic;
using System.Linq;

namespace RPS.Game.Validation
{
    public class EnrollmentValidator : IValidator
    {
        public void Validate(List<List<string>> players)
        {
            if (players.Any(x => x.Count != 2))
            {
                throw new InvalidEnrollmentException();
            }
        }
    }
}
