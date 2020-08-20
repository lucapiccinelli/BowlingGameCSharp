using System;
using System.Linq;

namespace BowlingGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Roll[] rolls = ParseInput(args);
            TotalScore totalScore = ComputeTotalScore(rolls);
            PrintTotalScore(totalScore);
        }

        private static void PrintTotalScore(TotalScore totalScore)
        {
            Console.WriteLine(totalScore);
        }

        private static TotalScore ComputeTotalScore(Roll[] rolls)
        {
            return new TotalScore(rolls.Sum(roll => roll.Value));
        }

        private static Roll[] ParseInput(string[] args)
        {
            return args
                .Select(int.Parse)
                .Select(i => new Roll(i))
                .ToArray();
        }
    }
}
