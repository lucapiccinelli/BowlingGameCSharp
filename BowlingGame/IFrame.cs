namespace BowlingGame
{
    public interface IFrame
    {
        IScore Score(BowlingRolls rolls);
    }
}