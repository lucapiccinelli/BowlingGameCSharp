using System;
using System.Linq;

namespace BowlingGame
{
    public static class Program
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
            int totalScoreValue = 0;
            int rollsNumber = rolls.Length;

            for (int i = 0; i < rollsNumber;)
            {
                Roll firstRoll = rolls[i++];
                totalScoreValue += firstRoll.Value;

                if (i < rollsNumber)
                {
                    Roll secondRoll = rolls[i++];
                    totalScoreValue += secondRoll.Value;

                    if (firstRoll.Value + secondRoll.Value == 10 && i < rollsNumber)
                    {
                        Roll bonusRoll = rolls[i];
                        totalScoreValue += bonusRoll.Value;
                    }
                }
            }


            return new TotalScore(totalScoreValue);
        }

        private static Roll[] ParseInput(string[] args) =>
            args
                .Select(int.Parse)
                .Select(i => new Roll(i))
                .ToArray();
    }
}
