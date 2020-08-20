using System;
using System.IO;
using Xunit;

namespace BowlingGame.Tests
{
    public class BowlingGameTests
    {
        // TODO: Show the totale score on the last line. Update the total score while running
        // TODO: Show the score by frame on the first line. Update the score only when the frame is closed. Otherwise show a "-"

        // all strikes
        // last frame

        [Theory]
        [InlineData("0", "0")]
        [InlineData("1", "1")]
        [InlineData("1 1", "2")]
        [InlineData("4 6 1", "12")]
        [InlineData("4 6", "10")]
        [InlineData("10 1 1", "14")]
        [InlineData("10", "10")]
        [InlineData("10 1", "12")]
        [InlineData("10 10 10 10 10 10 10 10 10 10 10 10", "300")]
        [InlineData("1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1", "20")]
        [InlineData("5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5", "150")]
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
