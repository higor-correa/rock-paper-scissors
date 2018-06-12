using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Bll.Exceptions;
using RockPaperScissors.Bll.Test.Utils;
using RockPaperScissors.Bll.Utils;
using System.Collections.Generic;

namespace RockPaperScissors.Bll.Test
{
    [TestClass]
    public class RpsGameTest
    {
        private RpsGame _rpsGame;
        public RpsGameTest()
        {
            _rpsGame = new RpsGame();
        }

        [TestMethod]
        public void Test_Winner_Game()
        {
            var actual = _rpsGame.rps_game_winner(new List<List<string>>
            {
                Players.PLAYER_1, Players.PLAYER_2
            });

            Assert.AreEqual(FormatWinnerResponse.Format(Players.PLAYER_2), actual);
        }

        [TestMethod]
        public void Test_First_Player_Winner()
        {
            var actual = _rpsGame.rps_game_winner(new List<List<string>>
            {
                Players.PLAYER_1, Players.PLAYER_3
            });

            Assert.AreEqual(FormatWinnerResponse.Format(Players.PLAYER_1), actual);
        }

        [TestMethod]
        public void Test_Incorrect_Move()
        {
            Assert.ThrowsException<NoSuchStrategyError>(() =>
            {
                _rpsGame.rps_game_winner(new List<List<string>>
                {
                    Players.PLAYER_1, Players.PLAYER_INCORRECT_MOVE
                });
            }, "Method RpsGame.rps_game_winner is allowing new moves!");
        }

        [TestMethod]
        public void Test_3_Players()
        {
            Assert.ThrowsException<WrongNumberOfPlayersError>(() =>
            {
                _rpsGame.rps_game_winner(new List<List<string>>
                {
                    Players.PLAYER_1, Players.PLAYER_2, Players.PLAYER_3
                });
            }, "Method RpsGame.rps_game_winner is allowing more than 2 players!");
        }
    }
}
