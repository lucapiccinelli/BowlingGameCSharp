using System.Collections.Generic;

namespace BowlingGame
{
    public class BowlingRolls
    {
        private readonly Queue<Roll> _rolls;

        public BowlingRolls(Queue<Roll> rolls)
        {
            _rolls = rolls;
        }

        public bool HasElements()
        {
            return CanRoll();
        }

        public Roll RollOne()
        {
            return _rolls.Dequeue();
        }

        public bool CanRoll()
        {
            return _rolls.Count > 0;
        }

        public Roll Bonus()
        {
            return _rolls.Peek();
        }
    }
}