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
                totalScore = Frame
                    .From(firstRoll)
                    .Score(rolls, totalScore);

                currentFrameNum++;
            }

            return totalScore;
        }
    }
}