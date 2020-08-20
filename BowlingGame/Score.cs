namespace BowlingGame
{
    public class Score : IScore
    {

        public Score(in int value = 0)
        {
            Value = value;
        }

        public IScore Plus(IScore score)
        {
            return score.Plus(Value, new FrameList());
        }

        public IScore Plus(int value, FrameList frames)
        {
            return new ScoreFrames(new Score(Value + value), frames);
        }

        public int Value { get; }
        public string Print()
        {
            return ToString();
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}