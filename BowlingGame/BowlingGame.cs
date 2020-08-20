namespace BowlingGame
{
    static public class BowlingGame
    {
        public static TotalScore ComputeTotalScore(BowlingRolls rolls)
        {
            TotalScore totalScore = new TotalScore(0);
            while (rolls.CanTake())
            {
                Roll firstRoll = rolls.TakeNext();
                totalScore = totalScore.Plus(firstRoll);

                if (firstRoll.IsStrike())
                {
                    totalScore = rolls.AssignBonus(totalScore, 2);
                }
                else
                {
                    if (rolls.CanTake())
                    {
                        Roll secondRoll = rolls.TakeNext();
                        totalScore = totalScore.Plus(secondRoll);

                        var frame = new Frame(firstRoll, secondRoll);
                        if (frame.IsSpare())
                        {
                            totalScore = rolls.AssignBonus(totalScore, 1);
                        }
                    }
                }
            }

            return totalScore;
        }
    }
}