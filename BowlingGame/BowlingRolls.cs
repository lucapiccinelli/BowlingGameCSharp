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

        public bool HasRolls()
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

        public Bonus Bonus(int howManyRolls)
        {
            var bonusValue = _rolls
                .Take(howManyRolls)
                .Sum(roll => roll.Value);
            return new Bonus(bonusValue);
        }
    }
}