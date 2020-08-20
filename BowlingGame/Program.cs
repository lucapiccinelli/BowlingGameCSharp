using System;
using System.Linq;

namespace BowlingGame
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            BowlingRolls rolls = ParseInput(args);
            TotalScore totalScore = ComputeTotalScore(rolls);
            PrintTotalScore(totalScore);
        }

        private static void PrintTotalScore(TotalScore totalScore)
        {
            Console.WriteLine(totalScore);
        }

        private static TotalScore ComputeTotalScore(BowlingRolls rolls)
        {
            TotalScore totalScore = new TotalScore(0);
            while(rolls.CanTake())
            {
                Roll firstRoll = rolls.TakeNext();
                totalScore = totalScore.Plus(firstRoll);

                if (rolls.CanTake())
                {
                    Roll secondRoll = rolls.TakeNext();
                    totalScore = totalScore.Plus(secondRoll);
                    if (IsSpare(firstRoll, secondRoll) && rolls.CanTake())
                    {
                        totalScore = rolls.AssignBonus(totalScore);
                    }
                }
            }

            return totalScore;
        }

        private static bool IsSpare(Roll firstRoll, Roll secondRoll)
        {
            return firstRoll.Value + secondRoll.Value == 10;
        }

        private static BowlingRolls ParseInput(string[] args) => new BowlingRolls(
            args
                .Select(int.Parse)
                .Select(i => new Roll(i))
                .ToArray());
    }
}
