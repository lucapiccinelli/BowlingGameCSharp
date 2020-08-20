namespace BowlingGame
{
    public class IncompleteScore : IScore
    {
        private readonly IScore _score;

        public IncompleteScore(IScore score, FrameList frames)
        {
            Frames = frames;
            _score = score;
        }

        public IScore Plus(IScore score)
        {
            return new IncompleteScore(_score.Plus(score), Frames);
        }

        public IScore Plus(int value, FrameList frames)
        {
            return new IncompleteScore(_score.Plus(value, frames), Frames.Add(frames));
        }

        public FrameList Frames { get; }

        public override string ToString()
        {
            return _score.ToString();
        }
    }
}