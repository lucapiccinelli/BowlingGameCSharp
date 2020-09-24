namespace BowlingGame
{
    public class SpareFrame
    {
        public static IScore Score(BowlingRolls rolls) => new MaxFrameScore(rolls).Score(1);
    }
}