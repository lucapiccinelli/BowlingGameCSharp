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
            var newScore = _score.Plus(score);
            return new IncompleteScore(newScore, newScore.Frames);
        }

        public IScore Plus(int value, FrameList frames)
        {
            var newScore = _score.Plus(value, frames);
            return new IncompleteScore(newScore, newScore.Frames);
        }

        public FrameList Frames { get; }

        public override string ToString()
        {
            return _score.ToString();
        }
    }
}