namespace BowlingGame
{
    public class Score : IScore
    {
        private readonly int _value;

        public Score(int value, FrameList frames)
        {
            _value = value;
            Frames = frames ?? new FrameList();
        }

        public Score(int value, IFrame frame)
        {
            _value = value;
            Frames = new FrameList().Add(frame);
        }


        public IScore Plus(int value, FrameList frames)
        {
            return new Score(value + _value, Frames.Add(frames));
        }

        public FrameList Frames { get; }

        private Score(Score score, FrameList frames) : this(score._value, frames)
        {
            
        }

        public override string ToString()
        {
            return _value.ToString();
        }

        public Score Plus(Roll roll)
        {
            return new Score(_value + roll.Value, Frames);
        }

        public IScore Plus(IScore score)
        {
            return score.Plus(_value, Frames);
        }
    }
}