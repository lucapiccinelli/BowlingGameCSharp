namespace BowlingGame
{
    public class Roll
    {
        public int Value { get; }

        public Roll(in int value)
        {
            Value = value;
        }
    }
}