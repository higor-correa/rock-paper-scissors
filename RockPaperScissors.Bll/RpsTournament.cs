using RockPaperScissors.Bll.Tournament;
using RockPaperScissors.Bll.Utils;
using System.Collections.Generic;

namespace RockPaperScissors.Bll
{
    public class RpsTournament
    {
        private readonly RpsBracketGame _engineBracketGame;

        public RpsTournament()
        {
            _engineBracketGame = new RpsBracketGame();
        }

        public string rps_tournament_winner(List<List<List<List<string>>>> game)
        {
            var winner = PlayTournament(game);

            return FormatWinnerResponse.Format(winner);
        }

        private List<string> PlayTournament(List<List<List<List<string>>>> game)
        {
            var winnersOfBrackets = new List<List<string>>();

            foreach (var bracket in game)
                winnersOfBrackets.Add(_engineBracketGame.PlayBracket(bracket));

            if (winnersOfBrackets.Count > 1)
            {
                var newBracket = _engineBracketGame.MakeNewBracket(winnersOfBrackets);
                return _engineBracketGame.PlayBracket(newBracket);
            }

            return winnersOfBrackets[0];
        }
    }
}
