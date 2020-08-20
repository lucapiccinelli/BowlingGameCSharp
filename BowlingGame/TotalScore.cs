namespace BowlingGame
{
    public class TotalScore
    {
        private readonly int _value;

        public TotalScore(int value)
        {
            _value = value;
        }

        public override string ToString()
        {
            return _value.ToString();
        }

        public TotalScore Plus(Roll firstRoll)
        {
            return new TotalScore(_value + firstRoll.Value);
        }
    }
}