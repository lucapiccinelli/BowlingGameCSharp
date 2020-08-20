using System;

namespace BowlingGame
{
    public class StrikeFrame : IFrame
    {
        private readonly BowlingRolls _bowlingRolls;
        private readonly Roll _firstRoll;
        private readonly Lazy<IScore> _score;

        public StrikeFrame(BowlingRolls bowlingRolls, Roll firstRoll)
        {
            _bowlingRolls = bowlingRolls;
            _firstRoll = firstRoll;
            _score = new Lazy<IScore>(() => ComputeScore(this));
        }

        public IScore Score => _score.Value;

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