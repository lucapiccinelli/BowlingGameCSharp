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
            TotalScore totalScore = new TotalScore(0);
            int rollsNumber = rolls.Length;

            for (int i = 0; CanTake(i, rollsNumber);)
            {
                Roll firstRoll = rolls[i++];
                totalScore = totalScore.Plus(firstRoll);

                if (CanTake(i, rollsNumber))
                {
                    Roll secondRoll = rolls[i++];
                    totalScore = totalScore.Plus(secondRoll);

                    if (IsSpare(firstRoll, secondRoll) && CanTake(i, rollsNumber))
                    {
                        totalScore = AssignBonus(rolls, i, totalScore);
                    }
                }
            }

            return totalScore;
        }

        private static bool CanTake(int i, int rollsNumber)
        {
            return i < rollsNumber;
        }

        private static bool IsSpare(Roll firstRoll, Roll secondRoll)
        {
            return firstRoll.Value + secondRoll.Value == 10;
        }

        private static TotalScore AssignBonus(Roll[] rolls, int i, TotalScore totalScore)
        {
            Roll bonusRoll = rolls[i];
            totalScore = totalScore.Plus(bonusRoll);
            return totalScore;
        }

        private static Roll[] ParseInput(string[] args) =>
            args
                .Select(int.Parse)
                .Select(i => new Roll(i))
                .ToArray();
    }
}
