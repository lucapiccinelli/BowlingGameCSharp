namespace BowlingGame
{
    static internal class Frame
    {
        public static IFrame From(BowlingRolls rolls, Roll firstRoll)
        {
            if (firstRoll.IsStrike()) return new StrikeFrame(rolls, firstRoll);
            return new OpenFrame(rolls, firstRoll);
        }

        public static IFrame From(BowlingRolls bowlingRolls, Roll firstRoll, Roll anotherRoll)
        {
            if (firstRoll.Value + anotherRoll.Value == 10)
            {
                return new SpareFrame(bowlingRolls, firstRoll, anotherRoll);
            }
            return new NormalFrame(firstRoll, anotherRoll);
        }
    }
}