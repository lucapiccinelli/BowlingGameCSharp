namespace BowlingGame
{
    static internal class Frame
    {
        public static IFrame From(Roll firstRoll)
        {
            if (firstRoll.IsStrike()) return new StrikeFrame(firstRoll);
            return new OpenFrame(firstRoll);
        }

        public static IFrame From(Roll firstRoll, Roll anotherRoll)
        {
            if (firstRoll.Value + anotherRoll.Value == 10)
            {
                return new SpareFrame(firstRoll, anotherRoll);
            }
            return new NormalFrame(firstRoll, anotherRoll);
        }
    }
}