using System.Linq;

namespace BowlingGame
{
    static public class ConsoleInputParser
    {
        public static BowlingRolls ParseInput(string[] args) => new BowlingRolls(
            args
                .Select(int.Parse)
                .Select(i => new Roll(i))
                .ToArray());
    }
}