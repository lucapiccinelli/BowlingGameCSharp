namespace BowlingGame
{
    public class SpareFrame
    {
        public static Score Score(BowlingRolls rolls) => new MaxFrameScore(rolls).Score(1);
    }
}