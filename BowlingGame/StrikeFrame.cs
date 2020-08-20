namespace BowlingGame
{
    public class StrikeFrame : IFrame
    {
        private readonly BowlingRolls _bowlingRolls;
        private readonly Roll _firstRoll;

        public StrikeFrame(BowlingRolls bowlingRolls, Roll firstRoll)
        {
            _bowlingRolls = bowlingRolls;
            _firstRoll = firstRoll;
        }

        public TotalScore Score(TotalScore totalScore)
        {
            return _bowlingRolls.AssignBonus(totalScore.Plus(_firstRoll), 2);
        }
    }
}