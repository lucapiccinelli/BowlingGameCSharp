namespace BowlingGame
{
    public class SpareFrame
    {
        public Score Score(BowlingRolls rolls) => new MaxFrameScore(rolls).Score(1);
    }
}