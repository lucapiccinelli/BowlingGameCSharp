using System;

namespace BowlingGame
{
    public class SpareFrame : IFrame
    {
        private readonly BowlingRolls _bowlingRolls;
        private readonly Roll _firstRoll;
        private readonly Roll _secondRoll;
        private readonly Lazy<IScore> _score;

        public SpareFrame(BowlingRolls bowlingRolls, Roll firstRoll, Roll secondRoll)
        {
            _bowlingRolls = bowlingRolls;
            _firstRoll = firstRoll;
            _secondRoll = secondRoll;

            _score = new Lazy<IScore>(() => ComputeScore(this));
        }

        public IScore ComputeScore(IFrame frame)
        {
            return _bowlingRolls.AssignBonus(new Score(_firstRoll.Value, frame).Plus(_secondRoll), 1);
        }

        public IScore Score => _score.Value;

        public override string ToString()
        {
            return Score.ToString();
        }
    }
}