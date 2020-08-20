namespace BowlingGame
{
    public class OpenFrame : IFrame
    {
        private readonly Roll _firstRoll;

        public OpenFrame(Roll firstRoll)
        {
            _firstRoll = firstRoll;
        }

        public TotalScore Score(BowlingRolls rolls, TotalScore totalScore)
        {
            return ScoreFromRollAnother(rolls, totalScore.Plus(_firstRoll), _firstRoll);
        }

        private TotalScore ScoreFromRollAnother(BowlingRolls rolls, TotalScore totalScore, Roll firstRoll)
        {
            if (rolls.CanTake())
            {
                var frame = RollAnother(rolls, ref totalScore, firstRoll);
                if (frame.IsSpare())
                {
                    totalScore = ScoreFromSpare(rolls, totalScore);
                }
                else
                {
                    totalScore = totalScore;
                }
            }

            return totalScore;
        }

        private Frame RollAnother(BowlingRolls rolls, ref TotalScore totalScore, Roll firstRoll)
        {
            Roll secondRoll = rolls.TakeNext();
            totalScore = totalScore.Plus(secondRoll);
            var frame = new Frame(firstRoll, secondRoll);
            return frame;
        }

        private TotalScore ScoreFromSpare(BowlingRolls rolls, TotalScore totalScore)
        {
            return rolls.AssignBonus(totalScore, 1);
        }
    }
}