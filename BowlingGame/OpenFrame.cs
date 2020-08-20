namespace BowlingGame
{
    public class OpenFrame : IFrame
    {
        private readonly Roll _firstRoll;

        public OpenFrame(Roll firstRoll)
        {
            _firstRoll = firstRoll;
        }

        public TotalScore Score(BowlingRolls rolls, TotalScore totalScore)
        {
            return _firstRoll
                .RollAnother(rolls)
                .Score(rolls, totalScore);
        }
    }
}