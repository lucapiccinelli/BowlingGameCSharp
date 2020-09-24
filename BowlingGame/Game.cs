namespace BowlingGame
{
    static public class Game
    {
        public static Score ComputeScore(BowlingRolls rolls)
        {
            Score totalScore = new Score();
            const int maxNumberOfFrames = 10;
            int currentOfFrames = 0;
            while(rolls.HasRolls() && currentOfFrames < maxNumberOfFrames)
            {
                var firstRoll = rolls.RollOne();
                var frame = Frame.From(firstRoll);
                totalScore = totalScore.Add(frame.Score(rolls));
                currentOfFrames++;
            }
            return totalScore;
        }
    }
}