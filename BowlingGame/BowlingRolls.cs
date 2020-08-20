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

        public bool CanTake(int howMany = 1)
        {
            return _rolls.Count >= howMany;
        }

        public Roll RollOne()
        {
            return _rolls.Dequeue();
        }

        public IScore AssignBonus(ScoreFrames scoreFrames, int howMany)
        {
            var bonus = _rolls
                .Take(howMany)
                .Aggregate(scoreFrames, (cumulatedScore, roll) => cumulatedScore.Plus(roll));

            return CanTake(howMany) 
                ? bonus
                : new IncompleteScore(bonus) as IScore;
        }
    }
}