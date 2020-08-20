using System;
using System.Linq;

namespace BowlingGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Roll[] rolls = ParseInput(args);
            int totalScore = ComputeTotalScore(rolls);
            PrintTotalScore(totalScore);
        }

        private static void PrintTotalScore(int totalScore)
        {
            Console.WriteLine(totalScore);
        }

        private static int ComputeTotalScore(Roll[] rolls)
        {
            return rolls.Sum(roll => roll.Value);
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
