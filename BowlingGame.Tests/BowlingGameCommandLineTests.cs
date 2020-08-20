using System;
using System.IO;
using Xunit;

namespace BowlingGame.Tests
{
    public class BowlingGameCommandLineTests
    {
        private readonly StringWriter _myOut;

        public BowlingGameCommandLineTests()
        {
            _myOut = new StringWriter();
            Console.SetOut(_myOut);
        }

        [Fact]
        public void GIVEN_AnInputFromTheCommandLine_WHEN_ItIsAListOfRolls_THEN_ItPrintsTheTotalScoreOnANewLine()
        {
            string rolls = "10 10 10";
            string expectedTotalScore = "60";
            string expectedPartialScore = "30,-,-";

            Program.Main(rolls.Split(" "));

            string[] outLines = OutLines();
            Assert.Equal(expectedPartialScore, outLines[0]);
            Assert.Equal(expectedTotalScore, outLines[1]);
        }

        private string[] OutLines()
        {
            return _myOut.ToString().Split(Environment.NewLine);
        }
    }
}
