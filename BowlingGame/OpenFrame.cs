namespace BowlingGame
{
    public class OpenFrame : IFrame
    {
        private readonly Roll _firstRoll;

        public OpenFrame(Roll firstRoll)
        {
            _firstRoll = firstRoll;
        }

        public IScore Score(BowlingRolls rolls)
        {
            if (rolls.CanRoll())
            {
                return EvaluateASpare(rolls, _firstRoll, rolls.RollOne());
            }
            return new Score(_firstRoll);
        }

        private IScore EvaluateASpare(BowlingRolls rolls, Roll firsRoll, Roll secondRoll)
        {
            var currentScore = new Score(firsRoll).Add(secondRoll);
            if (currentScore.IsSpare())
            {
                return SpareFrame.Score(rolls);
            }
            return currentScore;
        }
    }
}