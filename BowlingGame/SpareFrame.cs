namespace BowlingGame
{
    public class SpareFrame : IFrame
    {
        private readonly BowlingRolls _bowlingRolls;
        private readonly Roll _firstRoll;
        private readonly Roll _secondRoll;

        public SpareFrame(BowlingRolls bowlingRolls, Roll firstRoll, Roll secondRoll)
        {
            _bowlingRolls = bowlingRolls;
            _firstRoll = firstRoll;
            _secondRoll = secondRoll;
        }

        public TotalScore Score(TotalScore totalScore)
        {
            return _bowlingRolls.AssignBonus(totalScore.Plus(_firstRoll).Plus(_secondRoll), 1);
        }
    }
}