namespace BowlingGame
{
    public class Roll
    {
        public int Value { get; }

        public Roll(in int value)
        {
            Value = value;
        }

        public bool IsStrike()
        {
            return Value == 10;
        }
    }
}