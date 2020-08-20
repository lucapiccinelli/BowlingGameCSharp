using System;

namespace BowlingGame
{
    public class IncompleteStrike : IFrame
    {
        private readonly StrikeFrame _frame;
        private readonly Lazy<IScore> _score;

        public IncompleteStrike(StrikeFrame frame)
        {
            _frame = frame;
            _score = new Lazy<IScore>(() => _frame.ComputeScore(this));
        }

        public IScore Score => _score.Value;

        public override string ToString()
        {
            return "-";
        }
    }
}