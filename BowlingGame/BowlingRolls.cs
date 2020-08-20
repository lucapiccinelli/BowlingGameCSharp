using System.Collections.Generic;
using System.Linq;

namespace BowlingGame
{
    public class BowlingRolls
    {
        private readonly Queue<Roll> _rolls;

        public BowlingRolls(Roll[] rolls)
        {
            _rolls = new Queue<Roll>(rolls);
        }

        public bool CanTake()
        {
            return _rolls.Count > 0;
        }

        public Roll RollOne()
        {
            return _rolls.Dequeue();
        }

        public Score AssignBonus(Score score, int howMany)
        {
            return _rolls
                .Take(howMany)
                .Aggregate(score, (score, roll) => score.Plus(roll));
        }
    }
}