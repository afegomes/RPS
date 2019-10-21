using System.Collections.Generic;

namespace RPS.Game.Validation
{
    public interface IValidator
    {
        void Validate(List<List<string>> players);
    }
}
