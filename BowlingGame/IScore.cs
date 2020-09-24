﻿using System;

namespace BowlingGame
{
    public interface IScore
    {
        IScore Add(Roll secondRoll);
        IScore Add(IScore otherScore);
        IScore Add(Bonus bonus);
        Boolean IsSpare();
        TotalScore Add(TotalScore totalScore);

        int Value { get; }
    }
}