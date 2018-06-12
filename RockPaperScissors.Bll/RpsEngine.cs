using System.Collections.Generic;

namespace RockPaperScissors.Bll
{
    public class RpsEngine
    {
        public List<string> GetWinner(List<string> player1, List<string> player2)
        {
            var player1Move = player1[1];
            var player2Move = player2[1];

            if (player1Move == player2Move)
                return player1;

            List<string> winner = player1;

            switch (player1Move)
            {
                case "P":
                    winner = player2Move == "R" ? player1 : player2;
                    break;
                case "R":
                    winner = player2Move == "S" ? player1 : player2;
                    break;
                case "S":
                    winner = player2Move == "P" ? player1 : player2;
                    break;
            }

            return winner;
        }
    }
}
