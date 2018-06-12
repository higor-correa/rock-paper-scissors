using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Bll.Test.Utils;
using RockPaperScissors.Bll.Utils;
using System.Collections.Generic;

namespace RockPaperScissors.Bll.Test
{
    [TestClass]
    public class RpsTournamentTest
    {
        private RpsTournament _rpsTournament;
        public RpsTournamentTest()
        {
            _rpsTournament = new RpsTournament();
        }

        [TestMethod]
        public void Test_Winner_Tournament()
        {
            var actual = _rpsTournament.rps_tournament_winner(new List<List<List<List<string>>>>{

                new List<List<List<string>>>
                {
                    new List<List<string>>{Players.PLAYER_1, Players.PLAYER_2},
                    new List<List<string>>{Players.PLAYER_5, Players.PLAYER_6},
                },
                new List<List<List<string>>>
                {
                    new List<List<string>>{Players.PLAYER_7, Players.PLAYER_8},
                    new List<List<string>>{Players.PLAYER_9, Players.PLAYER_10}
                }
            });

            actual.Should().BeEquivalentTo(FormatWinnerResponse.Format(Players.PLAYER_5));
        }
    }
}
