using System;
using System.IO;
using System.Linq;
using Xunit;

namespace BowlingGame.Tests
{
    public class BowlingGameTests
    {
        [Theory]
        [InlineData("0", 0)]
        [InlineData("1", 1)]
        [InlineData("1 1", 2)]
        [InlineData("4 6 1", 12)]
        [InlineData("4 6", 10)]
        [InlineData("10 1 1", 14)]
        [InlineData("10", 10)]
        [InlineData("10 1", 12)]
        [InlineData("10 10 10 10 10 10 10 10 10 10 10 10", 300)]
        [InlineData("1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1", 20)]
        [InlineData("5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5", 150)]
        [InlineData("10 10 10", 60)]
        public void GIVEN_AnInputListOfRolls_WHEN_AScoreIsComputed_THEN_returnsAsExpected(string rollsString, int expectedTotalScore)
        {
            BowlingRolls rolls = ParserRolls(rollsString);
            var score = BowlingGame.ComputeTotalScore(rolls);

            Assert.Equal(expectedTotalScore, score.Value);

        }

        [Theory]
        [InlineData("0", "-")]
        [InlineData("1", "-")]
        [InlineData("1 1", "2")]
        [InlineData("4 6 1", "11,-")]
        [InlineData("4 6", "-")]
        [InlineData("10 1 1", "12,2")]
        [InlineData("10", "-")]
        [InlineData("10 1", "-,-")]
        [InlineData("10 10 10 10 10 10 10 10 10 10 10 10", "30,30,30,30,30,30,30,30,30,30")]
        [InlineData("1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1", "2,2,2,2,2,2,2,2,2,2")]
        [InlineData("2 1 2 6 1 3 1 1 1 1 1 1 1 1 1 1 1 1 1 1", "3,8,4,2,2,2,2,2,2,2")]
        [InlineData("5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5", "15,15,15,15,15,15,15,15,15,15")]
        [InlineData("10 10 10", "30,-,-")]
        public void GIVEN_AnInputFromTheCommandLine_WHEN_ItIsAListOfRolls_THEN_ItPrintsThePartialScoreOnANewLine(string rollsString, string expectedPartialScore)
        {
            BowlingRolls rolls = ParserRolls(rollsString);
            var score = BowlingGame.ComputeTotalScore(rolls);

            Assert.Equal(expectedPartialScore, score.PrintFrames());
        }

        private BowlingRolls ParserRolls(string rollsString) => ConsoleInputParser.ParseInput(rollsString.Split(" "));
    }
}
