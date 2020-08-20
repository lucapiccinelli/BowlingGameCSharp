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

        public IScore Score =>
            _firstRoll
                .RollAnother(_bowlingRolls).Score;

        public override string ToString()
        {
            return Score.ToString();
        }
    }
}