namespace BowlingGame
{
    public class IncompleteFrame : IFrame
    {
        private readonly Roll _roll;

        public IncompleteFrame(Roll roll)
        {
            _roll = roll;
        }

        public Score Score(Score score)
        {
            return score.Plus(this);
        }

        public Score Score()
        {
            return new Score(_roll.Value);
        }
    }
}