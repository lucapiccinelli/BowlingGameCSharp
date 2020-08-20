using System;
using System.Linq;

namespace BowlingGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] rolls = args.Select(int.Parse).ToArray();
            Console.WriteLine(rolls.Sum());
        }
    }
}
