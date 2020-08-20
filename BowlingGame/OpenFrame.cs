namespace BowlingGame
{
    public class OpenFrame : IFrame
    {
        private readonly BowlingRolls _bowlingRolls;
        private readonly Roll _firstRoll;

        public OpenFrame(BowlingRolls bowlingRolls, Roll firstRoll)
        {
            _bowlingRolls = bowlingRolls;
            _firstRoll = firstRoll;
        }

        public TotalScore Score(TotalScore totalScore)
        {
            return _firstRoll
                .RollAnother(_bowlingRolls)
                .Score(totalScore);
        }
    }
}