namespace BowlingGame
{
    public class IncompleteFrame : IFrame
    {
        private readonly Roll _roll;

        public IncompleteFrame(Roll roll)
        {
            _roll = roll;
        }

        public TotalScore Score(BowlingRolls rolls, TotalScore totalScore)
        {
            return totalScore.Plus(_roll);
        }
    }
}