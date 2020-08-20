namespace BowlingGame
{
    public class IncompleteFrame : IFrame
    {
        private readonly Roll _roll;

        public IncompleteFrame(Roll roll)
        {
            _roll = roll;
        }

        public IScore Score => new Score(_roll.Value, this);

        public override string ToString()
        {
            return "-";
        }
    }
}