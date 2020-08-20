namespace BowlingGame
{
    static internal class Frame
    {
        public static IFrame From(BowlingRolls rolls, Roll firstRoll)
        {
            if (firstRoll.IsStrike())
            {
                var strikeFrame = new StrikeFrame(rolls, firstRoll);
                if (strikeFrame.CanComplete())
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
                if (spareFrame.CanComplete())
                    return spareFrame;
                return new IncompleteSpare(spareFrame);
                
            }
            return new NormalFrame(firstRoll, anotherRoll);
        }
    }
}