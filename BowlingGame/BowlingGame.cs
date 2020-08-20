namespace BowlingGame
{
    static public class BowlingGame
    {
        private const int MaxFrames = 10;

        public static IScore ComputeTotalScore(BowlingRolls rolls)
        {
            IScore totalScore = new Score();
            int currentFrameNum = 0;
            while (rolls.CanTake() && currentFrameNum < MaxFrames)
            {
                Roll firstRoll = rolls.RollOne();
                totalScore = Frame
                    .From(rolls, firstRoll)
                    .Score
                    .Plus(totalScore);

                currentFrameNum++;
            }

            return totalScore;
        }
    }
}