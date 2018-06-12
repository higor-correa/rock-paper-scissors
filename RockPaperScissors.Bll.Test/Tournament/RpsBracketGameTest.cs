using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Bll.Test.Utils;
using RockPaperScissors.Bll.Tournament;
using System.Collections.Generic;

namespace RockPaperScissors.Bll.Test.Tournament
{
    [TestClass]
    public class RpsBracketGameTest
    {
        private RpsBracketGame _rpsBracketGame;
        public RpsBracketGameTest()
        {
            _rpsBracketGame = new RpsBracketGame();
        }

        [TestMethod]
        public void Test_Make_New_Bracket()
        {
            var actual = _rpsBracketGame.MakeNewBracket(new List<List<string>>
            {
                Players.PLAYER_1, Players.PLAYER_2, Players.PLAYER_3, Players.PLAYER_4
            });

            actual.Should().BeEquivalentTo(new List<List<List<string>>>
            {
                new List<List<string>> { Players.PLAYER_1, Players.PLAYER_2 },
                new List<List<string>> { Players.PLAYER_3, Players.PLAYER_4 }
            });

        }

        [TestMethod]
        public void Test_Winner_Bracket()
        {
            var actual = _rpsBracketGame.PlayBracket(new List<List<List<string>>>
            {
                new List<List<string>> { Players.PLAYER_1, Players.PLAYER_2 },
                new List<List<string>> { Players.PLAYER_3, Players.PLAYER_4 }
            });

            actual.Should().BeEquivalentTo(Players.PLAYER_2);
        }
    }
}
