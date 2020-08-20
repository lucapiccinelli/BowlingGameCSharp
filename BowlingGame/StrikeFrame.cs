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

        public IScore Score => ComputeScore(this);

        public override string ToString()
        {
            return Score.ToString();
        }

        public IScore ComputeScore(IFrame frame)
        {
            return _bowlingRolls.AssignBonus(new Score(_firstRoll.Value, frame), 2);
        }
    }
}