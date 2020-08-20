namespace BowlingGame
{
    public class IncompleteScore : IScore
    {
        private readonly IScore _score;

        public IncompleteScore(IScore score)
        {
            _score = score;
        }

        public IScore Plus(IScore score)
        {
            var newScore = _score.Plus(score);
            return new IncompleteScore(newScore);
        }

        public IScore Plus(int value, FrameList frames)
        {
            var newScore = _score.Plus(value, frames);
            return new IncompleteScore(newScore);
        }

        public int Value => _score.Value;
        public string Print()
        {
            return _score.Print();
        }

        public override string ToString()
        {
            return _score.ToString();
        }
    }
}