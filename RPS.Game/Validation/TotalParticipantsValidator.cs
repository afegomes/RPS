using System.Collections.Generic;

namespace RPS.Game.Validation
{
    public class TotalParticipantsValidator : IValidator
    {
        public int Needed { get; private set; }

        public TotalParticipantsValidator(int needed)
        {
            Needed = needed;
        }

        public void Validate(List<List<string>> players)
        {
            if (players.Count != Needed)
            {
                throw new WrongNumberOfPlayersError();
            }
        }
    }
}
