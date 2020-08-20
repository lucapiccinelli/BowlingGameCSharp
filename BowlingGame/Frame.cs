namespace BowlingGame
{
    public class Frame
    {
        private readonly Roll _firstRoll;
        private readonly Roll _secondRoll;

        public Frame(Roll firstRoll, Roll secondRoll)
        {
            _firstRoll = firstRoll;
            _secondRoll = secondRoll;
        }

        public bool IsSpare()
        {
            return _firstRoll.Value + _secondRoll.Value == 10;
        }
    }
}