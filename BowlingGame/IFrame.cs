namespace BowlingGame
{
    public interface IFrame
    {
        TotalScore Score(BowlingRolls rolls, TotalScore totalScore);
    }
}