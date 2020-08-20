namespace BowlingGame
{
    public class Score
    {
        private readonly int _value;

        public Score(int value, FrameList frames = null)
        {
            _value = value;
            Frames = frames ?? new FrameList();
        }

        public readonly FrameList Frames;

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

        public Score Plus(IFrame frame)
        {
            return new Score(frame.Score, Frames.Add(frame));
        }

        public Score Plus(Score score)
        {
            return new Score(_value + score._value, Frames.Add(score.Frames));
        }
    }
}