namespace BowlingGame
{
    public class TotalScore
    {
        private readonly int _value;

        public TotalScore(int value, FrameList frames = null)
        {
            _value = value;
            Frames = frames ?? new FrameList();
        }

        public readonly FrameList Frames;

        public override string ToString()
        {
            return _value.ToString();
        }

        public TotalScore Plus(Roll roll)
        {
            return new TotalScore(_value + roll.Value, Frames);
        }
    }
}