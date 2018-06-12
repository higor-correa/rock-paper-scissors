using RockPaperScissors.Bll.Validators;
using System.Collections.Generic;

namespace RockPaperScissors.Bll.Tournament
{
    public class RpsBracketGame
    {
        private readonly RpsValidator _gameValidator;
        private readonly RpsEngine _engine;

        public RpsBracketGame()
        {
            _engine = new RpsEngine();
            _gameValidator = new RpsValidator();
        }

        public List<string> PlayBracket(List<List<List<string>>> bracket)
        {
            var subBracketWinner = new List<List<string>>();

            foreach (var subBracket in bracket)
            {
                _gameValidator.Validate(subBracket);
                subBracketWinner.Add(_engine.GetWinner(subBracket[0], subBracket[1]));
            }

            if (subBracketWinner.Count > 1)
                return PlayBracket(MakeNewBracket(subBracketWinner));

            return subBracketWinner[0];
        }

        public List<List<List<string>>> MakeNewBracket(List<List<string>> subBracketWinner)
        {
            var bracket = new List<List<List<string>>>();

            for (int i = 0; i < subBracketWinner.Count; i = i + 2)
                bracket.Add(new List<List<string>> { subBracketWinner[i], subBracketWinner[i + 1] });

            return bracket;
        }
    }
}
