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

                if (rolls.CanTake())
                {
                    Roll secondRoll = rolls.TakeNext();
                    totalScore = totalScore.Plus(secondRoll);

                    var frame = new Frame(firstRoll, secondRoll);
                    if (frame.IsSpare() && rolls.CanTake())
                    {
                        totalScore = rolls.AssignBonus(totalScore);
                    }
                }
            }

            return totalScore;
        }
    }
}