using System;
using System.Linq;

namespace BowlingGame
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            BowlingRolls rolls = ParseInput(args);
            TotalScore totalScore = BowlingGame.ComputeTotalScore(rolls);
            PrintTotalScore(totalScore);
        }

        private static void PrintTotalScore(TotalScore totalScore)
        {
            Console.WriteLine(totalScore);
        }

        private static BowlingRolls ParseInput(string[] args) => new BowlingRolls(
            args
                .Select(int.Parse)
                .Select(i => new Roll(i))
                .ToArray());
    }
}
