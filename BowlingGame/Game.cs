namespace BowlingGame
{
    public static class Game
    {
        public static Score ComputeScore(BowlingRolls rolls)
        {
            const int maxNumberOfFrames = 10;
            int currentNumberOfFrames = 0;

            Score totalScore = new Score();
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