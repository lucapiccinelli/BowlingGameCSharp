using System;
using System.IO;
using Xunit;

namespace BowlingGame.Tests
{
    public class BowlingGameTests
    {
        // TODO: Show the totale score on the last line. Update the total score while running
        // TODO: Show the score by frame on the first line. Update the score only when the frame is closed. Otherwise show a "-"

        // One zero
        // all zeros
        // One zero frame
        // Open frame
        // all open frame
        // spare
        // all spare
        // strike
        // all strikes
        // last frame

        [Theory]
        [InlineData("0", "0")]
        public void GIVEN_AnInputFromTheCommandLine_WHEN_ItIsAListOfRolls_THEN_ItPrintsTheTotalScoreOnANewLine(string rolls, string expectedTotalScore)
        {
            var myOut = new StringWriter();
            Console.SetOut(myOut);

            Program.Main(rolls.Split(" "));

            string[] outLines = myOut.ToString().Split(Environment.NewLine);
            Assert.Equal(expectedTotalScore, outLines[0]);
        }
    }
}
