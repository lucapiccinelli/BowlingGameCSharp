namespace BowlingGame
{
    public class StrikeFrame : IFrame
    {
        private readonly Roll _firstRoll;

        public StrikeFrame(Roll firstRoll)
        {
            _firstRoll = firstRoll;
        }

        public TotalScore Score(BowlingRolls rolls, TotalScore totalScore)
        {
            return rolls.AssignBonus(totalScore.Plus(_firstRoll), 2);
        }
    }
}