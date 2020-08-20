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

        public Roll TakeNext()
        {
            return _rolls.Dequeue();
        }

        public TotalScore AssignBonus(TotalScore totalScore, int howMany)
        {
            return _rolls
                .Take(howMany)
                .Aggregate(totalScore, (score, roll) => score.Plus(roll));
        }
    }
}