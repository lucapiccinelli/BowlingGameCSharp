namespace BowlingGame
{
    public class IncompleteStrike : IFrame
    {
        private readonly StrikeFrame _strikeFrame;

        public IncompleteStrike(StrikeFrame strikeFrame)
        {
            _strikeFrame = strikeFrame;
            
        }

        public IScore Score => _strikeFrame.ComputeScore(this);

        public override string ToString()
        {
            return "-";
        }
    }
}