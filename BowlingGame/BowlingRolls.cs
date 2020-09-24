using System.Collections.Generic;
using System.Linq;

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

        public Roll Bonus(int position = 0)
        {
            if (_rolls.Count > position)
            {
                if (position == 0) return _rolls.Peek();
                return _rolls.Skip(1).First();
            }
            return new Roll(0);
        }
    }
}