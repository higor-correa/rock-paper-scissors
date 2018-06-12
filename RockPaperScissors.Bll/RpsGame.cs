using RockPaperScissors.Bll.Utils;
using RockPaperScissors.Bll.Validators;
using System.Collections.Generic;

namespace RockPaperScissors.Bll
{
    public class RpsGame
    {
        private readonly RpsValidator _gameValidator;
        private readonly RpsEngine _engine;

        public RpsGame()
        {
            _gameValidator = new RpsValidator();
            _engine = new RpsEngine();
        }

        public string rps_game_winner(List<List<string>> game)
        {
            _gameValidator.Validate(game);

            var winner = _engine.GetWinner(game[0], game[1]);
            return FormatWinnerResponse.Format(winner);
        }
    }
}
