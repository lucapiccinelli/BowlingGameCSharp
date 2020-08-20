namespace BowlingGame
{
    static public class BowlingGame
    {
        private const int MaxFrames = 10;

        public static TotalScore ComputeTotalScore(BowlingRolls rolls)
        {
            TotalScore totalScore = new TotalScore(0);
            int currentFrameNum = 0;
            while (rolls.CanTake() && currentFrameNum < MaxFrames)
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

                currentFrameNum++;
            }

            return totalScore;
        }
    }
}