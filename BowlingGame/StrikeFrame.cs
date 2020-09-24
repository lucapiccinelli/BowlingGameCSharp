namespace BowlingGame
{
    public class StrikeFrame : IFrame
    {
        public Score Score(BowlingRolls rolls) => new MaxFrameScore(rolls).Score(2);
    }
}