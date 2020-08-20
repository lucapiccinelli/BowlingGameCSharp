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

        public Score Score => _bowlingRolls.AssignBonus(new Score(_firstRoll.Value, this), 2);

        public override string ToString()
        {
            return Score.ToString();
        }
    }
}