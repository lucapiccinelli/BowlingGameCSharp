namespace BowlingGame
{
    public class IncompleteSpare : IFrame
    {
        private readonly SpareFrame _spareFrame;

        public IncompleteSpare(SpareFrame spareFrame)
        {
            _spareFrame = spareFrame;
        }

        public IScore Score => _spareFrame.ComputeScore(this);

        public override string ToString()
        {
            return "-";
        }
    }
}