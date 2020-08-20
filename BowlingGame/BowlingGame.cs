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
                totalScore = AddFrameScore(rolls, totalScore, firstRoll);

                currentFrameNum++;
            }

            return totalScore;
        }

        private static TotalScore AddFrameScore(BowlingRolls rolls, TotalScore totalScore, Roll firstRoll)
        {
            totalScore = totalScore.Plus(firstRoll);
            totalScore = firstRoll.IsStrike() 
                ? ScoreFromStrike(rolls, totalScore) 
                : ScoreFromRollAnother(rolls, totalScore, firstRoll);

            return totalScore;
        }

        private static TotalScore ScoreFromRollAnother(BowlingRolls rolls, TotalScore totalScore, Roll firstRoll)
        {
            if (rolls.CanTake())
            {
                var frame = RollAnother(rolls, ref totalScore, firstRoll);
                if (frame.IsSpare())
                {
                    totalScore = ScoreFromSpare(rolls, totalScore);
                }
                else
                {
                    totalScore = totalScore;
                }
            }

            return totalScore;
        }

        private static Frame RollAnother(BowlingRolls rolls, ref TotalScore totalScore, Roll firstRoll)
        {
            Roll secondRoll = rolls.TakeNext();
            totalScore = totalScore.Plus(secondRoll);
            var frame = new Frame(firstRoll, secondRoll);
            return frame;
        }

        private static TotalScore ScoreFromSpare(BowlingRolls rolls, TotalScore totalScore)
        {
            return rolls.AssignBonus(totalScore, 1);
        }

        private static TotalScore ScoreFromStrike(BowlingRolls rolls, TotalScore totalScore)
        {
            totalScore = rolls.AssignBonus(totalScore, 2);
            return totalScore;
        }
    }
}