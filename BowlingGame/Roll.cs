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

        public IFrame RollAnother(BowlingRolls rolls)
        {
            if (rolls.CanTake())
            {
                var anotherRoll = rolls.RollOne();
                return Frame.From(this, anotherRoll);
            }
            else
            {
                return new IncompleteFrame(this);
            }
        }
    }
}