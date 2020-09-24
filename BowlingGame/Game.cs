namespace BowlingGame
{
    public static class Game
    {
        public static TotalScore ComputeScore(BowlingRolls rolls)
        {
            const int maxNumberOfFrames = 10;
            int currentNumberOfFrames = 0;

            TotalScore totalScore = new TotalScore();
            while(rolls.HasRolls() && currentNumberOfFrames < maxNumberOfFrames)
            {
                totalScore = Frame
                    .From(rolls.RollOne())
                    .Score(rolls)
                    .Add(totalScore);
                currentNumberOfFrames++;
            }
            return totalScore;
        }
    }
}