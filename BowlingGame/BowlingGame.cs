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
                var frame = Frame.From(rolls, firstRoll);
                var score = frame.Score;
                totalScore = totalScore.Plus(score);

                currentFrameNum++;
            }

            return totalScore;
        }
    }
}