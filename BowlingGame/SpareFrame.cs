namespace BowlingGame
{
    public class SpareFrame : IFrame
    {
        private readonly Roll _firstRoll;
        private readonly Roll _secondRoll;

        public SpareFrame(Roll firstRoll, Roll secondRoll)
        {
            _firstRoll = firstRoll;
            _secondRoll = secondRoll;
        }

        public TotalScore Score(BowlingRolls rolls, TotalScore totalScore)
        {
            return rolls.AssignBonus(totalScore.Plus(_firstRoll).Plus(_secondRoll), 1);
        }
    }
}