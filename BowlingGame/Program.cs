using System;
using System.Linq;

namespace BowlingGame
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            BowlingRolls rolls = ParseInput(args);
            Score score = BowlingGame.ComputeTotalScore(rolls);
            PrintTotalScore(score);
        }

        private static void PrintTotalScore(Score score)
        {
            Console.WriteLine(score.Frames);
            Console.WriteLine(score);
        }

        private static BowlingRolls ParseInput(string[] args) => new BowlingRolls(
            args
                .Select(int.Parse)
                .Select(i => new Roll(i))
                .ToArray());
    }
}
