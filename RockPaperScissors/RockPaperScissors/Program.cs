using RockPaperScissors.Bll;
using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            var winner = new RpsGame().rps_game_winner(new List<List<string>>
            {
                new List<string> { "Armando", "P" },
                new List<string> { "Dave", "S" },
            });

            Console.WriteLine("X1 winner: " + winner);

            winner = new RpsTournament().rps_tournament_winner(
new List<List<List<List<string>>>>{

    new List<List<List<string>>>
    {
        new List<List<string>>
        {
            new List<string>{ "Armando", "P" },
            new List<string>{ "Dave", "S" }
        },
        new List<List<string>>
        {
            new List<string>{"Richard", "R"},
            new List<string>{"Michael", "S"}
        },
    },
    new List<List<List<string>>>
    {
        new List<List<string>>
        {
            new List<string>{"Allen", "S"},
            new List<string>{"Omer", "P"}
        },
        new List<List<string>>
        {
            new List<string>{"David E.", "R"},
            new List<string>{"Richard X.", "P"}
        }
    }
});
            Console.WriteLine("Tournament winner: " + winner);
            Console.ReadLine();
        }

    }
}
