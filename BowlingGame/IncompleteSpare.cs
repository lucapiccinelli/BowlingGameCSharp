using System;

namespace BowlingGame
{
    public class IncompleteSpare : IFrame
    {
        private readonly SpareFrame _frame;
        private readonly Lazy<IScore> _score;

        public IncompleteSpare(SpareFrame frame)
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