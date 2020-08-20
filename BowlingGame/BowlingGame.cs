namespace BowlingGame
{
    static public class BowlingGame
    {
        private const int MaxFrames = 10;

        public static IScore ComputeTotalScore(BowlingRolls rolls)
        {
            IScore score = new Score(0, new FrameList());
            int currentFrameNum = 0;
            while (rolls.CanTake() && currentFrameNum < MaxFrames)
            {
                Roll firstRoll = rolls.RollOne();
                score = Frame
                    .From(rolls, firstRoll)
                    .Score
                    .Plus(score);

                currentFrameNum++;
            }

            return score;
        }
    }
}