namespace BowlingGame
{
    static internal class Frame
    {
        public static IFrame From(BowlingRolls rolls, Roll firstRoll)
        {
            if (firstRoll.IsStrike())
            {
                var strikeFrame = new StrikeFrame(rolls, firstRoll);
                if (rolls.CanTake(2))
                    return strikeFrame;
                return new IncompleteStrike(strikeFrame);
            }
            return new OpenFrame(rolls, firstRoll);
        }

        public static IFrame From(BowlingRolls bowlingRolls, Roll firstRoll, Roll anotherRoll)
        {
            if (firstRoll.Value + anotherRoll.Value == 10)
            {
                var spareFrame = new SpareFrame(bowlingRolls, firstRoll, anotherRoll);
                if (bowlingRolls.CanTake(1))
                    return spareFrame;
                return new IncompleteSpare(spareFrame);
                
            }
            return new NormalFrame(firstRoll, anotherRoll);
        }
    }

    public class IncompleteSpare : IFrame
    {
        private readonly SpareFrame _spareFrame;

        public IncompleteSpare(SpareFrame spareFrame)
        {
            _spareFrame = spareFrame;
        }

        public IScore Score => _spareFrame.ComputeScore(this);

        public override string ToString()
        {
            return "-";
        }
    }

    public class IncompleteStrike : IFrame
    {
        private readonly StrikeFrame _strikeFrame;

        public IncompleteStrike(StrikeFrame strikeFrame)
        {
            _strikeFrame = strikeFrame;
            
        }

        public IScore Score => _strikeFrame.ComputeScore(this);

        public override string ToString()
        {
            return "-";
        }
    }
}