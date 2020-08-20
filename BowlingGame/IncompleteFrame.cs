namespace BowlingGame
{
    public class IncompleteFrame : IFrame
    {
        private readonly Roll _roll;

        public IncompleteFrame(Roll roll)
        {
            _roll = roll;
        }

        public Score Score => new Score(_roll.Value);

        public override string ToString()
        {
            return "-";
        }
    }
}