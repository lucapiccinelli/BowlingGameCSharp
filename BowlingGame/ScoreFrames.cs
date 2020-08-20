using System;

namespace BowlingGame
{
    public class ScoreFrames : IScore
    {
        private readonly IScore _score;
        public int Value => _score.Value;

        public FrameList Frames { get; }

        public ScoreFrames(IScore score, FrameList frames)
        {
            _score = score;
            Frames = frames ?? new FrameList();
        }

        public ScoreFrames(IScore score, IFrame frame)
        {
            _score = score;
            Frames = new FrameList().Add(frame);
        }


        public IScore Plus(int value, FrameList frames)
        {
            return new ScoreFrames(new Score(value + Value), Frames.Add(frames));
        }

        public string Print()
        {
            return $"{PrintFrames()}{Environment.NewLine}{_score}";
        }

        public string PrintFrames()
        {
            return Frames.ToString();
        }

        public override string ToString()
        {
            return _score.ToString();
        }

        public ScoreFrames Plus(Roll roll)
        {
            return new ScoreFrames(new Score(Value + roll.Value), Frames);
        }

        public IScore Plus(IScore score)
        {
            return score.Plus(Value, Frames);
        }
    }
}