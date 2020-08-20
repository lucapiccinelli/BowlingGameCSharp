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

        private BowlingRolls ParserRolls(string rollsString) => new BowlingRolls(
            rollsString.Split(" ")
                .Select(int.Parse)
                .Select(i => new Roll(i))
                .ToArray()
            );
    }
}
