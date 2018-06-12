using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Bll.Test.Utils;

namespace RockPaperScissors.Bll.Test
{
    [TestClass]
    public class RpsEngineTest
    {
        private RpsEngine _rpsEngine;
        public RpsEngineTest()
        {
            _rpsEngine = new RpsEngine();
        }

        [TestMethod]
        public void Test_Winner_Engine()
        {
            var actual = _rpsEngine.GetWinner(Players.PLAYER_1, Players.PLAYER_2);

            actual.Should().BeEquivalentTo(Players.PLAYER_2);
        }

        [TestMethod]
        public void Test_First_Winner_Engine()
        {
            var actual = _rpsEngine.GetWinner(Players.PLAYER_1, Players.PLAYER_3);

            actual.Should().BeEquivalentTo(Players.PLAYER_1);
        }

        [TestMethod]
        public void Test_Winner_When_Same_Move()
        {
            var actual = _rpsEngine.GetWinner(Players.PLAYER_1, Players.PLAYER_4);

            actual.Should().BeEquivalentTo(Players.PLAYER_1);
        }
    }
}
