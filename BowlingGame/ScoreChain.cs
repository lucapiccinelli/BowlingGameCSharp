namespace BowlingGame
{
    public class ScoreChain : IScore
    {
        private readonly IScore _previousScore;
        private readonly IScore _currentScore;

        public ScoreChain(IScore previousScore, IScore currentScore)
        {
            _previousScore = previousScore;
            _currentScore = currentScore;
        }

        public TotalScore Add(TotalScore totalScore) => totalScore.Add(this);

        public IScore Add(Roll secondRoll) => new ScoreChain(this, _currentScore.Add(secondRoll));

        public IScore Add(IScore otherScore) => new ScoreChain(this, otherScore);

        public IScore Add(Bonus bonus) => new ScoreChain(this, _currentScore.Add(bonus));

        public bool IsSpare() => _currentScore.IsSpare();

        public int Value => _previousScore.Value + _currentScore.Value;

        public override string ToString()
        {
            return $"{_previousScore},{_currentScore}";
        }
    }
}