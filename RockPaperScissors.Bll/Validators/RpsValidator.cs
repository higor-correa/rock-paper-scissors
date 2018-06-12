using RockPaperScissors.Bll.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissors.Bll.Validators
{
    public class RpsValidator
    {
        private readonly List<string> _allowedMovements;

        public RpsValidator()
        {
            _allowedMovements = new List<string> { "S", "P", "R" };
        }

        public void Validate(List<List<string>> game)
        {
            if (game.Count != 2)
                throw new WrongNumberOfPlayersError("Number of players must to be 2!");

            if (game.Any(g => !_allowedMovements.Contains(g[1])))
                throw new NoSuchStrategyError(string.Format("Moves must to be one of these {0}", string.Join(", ", _allowedMovements)));
        }
    }
}
