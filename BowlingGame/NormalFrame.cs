namespace BowlingGame
{
    public class NormalFrame : IFrame
    {
        private readonly Roll _firstRoll;
        private readonly Roll _secondRoll;

        public NormalFrame(Roll firstRoll, Roll secondRoll)
        {
            _firstRoll = firstRoll;
            _secondRoll = secondRoll;
        }

        public TotalScore Score(BowlingRolls rolls, TotalScore totalScore)
        {
            return totalScore.Plus(_firstRoll).Plus(_secondRoll);
        }
    }
}