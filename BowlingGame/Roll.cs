using System;

namespace BowlingGame
{
    public class Roll
    {
        public int Value { get; }

        public Roll(in int value)
        {
            if (value > 10) throw new RollValueException(value);
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
                return Frame.From(rolls, this, anotherRoll);
            }
            else
            {
                return new IncompleteFrame(this);
            }
        }
    }

    public class RollValueException : Exception
    {
        private readonly int _value;

        public RollValueException(in int value) : base("Can't roll more than 10 pins")
        {
            _value = value;
        }
    }
}