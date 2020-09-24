using System;
using System.IO;
using Xunit;

namespace BowlingGame.Tests
{
    public class BowlingGameTests
    {
        // TODO: Show the total score on the last line. Update the total score while running. When a frame is incomplete it sums its current value.
        // TODO: Show the score by frame on the first line. Update the score only when the frame is closed. Otherwise show a "-".

        // all spare
        // strike
        // all strikes
        // last frame

        [Theory]
        [InlineData("0", "0")]
        [InlineData("1", "1")]
        [InlineData("1,1", "2")]
        [InlineData("5,5", "10")]
        [InlineData("5,5,1", "12")]
        [InlineData("0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0", "0")]
        [InlineData("1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1", "20")]
        //[InlineData("5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5", "150")]
        public void GIVEN_AnInputFromTheCommandLine_WHEN_ItIsAListOfRolls_THEN_ItPrintsTheTotalScoreOnANewLine(string inputRollsStr, string expectedTotalScore)
        {
            using var myOut = new StringWriter();
            Console.SetOut(myOut);

            string[] inputRolls = inputRollsStr.Split(",");
            MyProgram.Main(inputRolls);

            var outLines = myOut.ToString().Split(Environment.NewLine);
            Assert.Equal(expectedTotalScore, outLines[0]);
        }
    }
}
