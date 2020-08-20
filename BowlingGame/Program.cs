using System;
using System.Linq;

namespace BowlingGame
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            try
            {
                BowlingRolls rolls = ConsoleInputParser.ParseInput(args);
                IScore score = BowlingGame.ComputeTotalScore(rolls);
                PrintTotalScore(score);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error! {e.Message}");
                return 1;
            }

            return 0;
        }

        private static void PrintTotalScore(IScore score)
        {
            Console.WriteLine(score.Print());
        }
    }
}
