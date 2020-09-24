using System;

namespace BowlingGame
{
    public interface IScore
    {
        IScore Add(Roll secondRoll);
        IScore Add(IScore otherScore);
        IScore Add(IBonus bonus);
        Boolean IsSpare();
        TotalScore Add(TotalScore totalScore);

        int Value { get; }
    }
}