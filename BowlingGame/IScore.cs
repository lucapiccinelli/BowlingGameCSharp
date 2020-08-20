using System.Collections.Generic;

namespace BowlingGame
{
    public interface IScore
    {
        IScore Plus(IScore score);
        IScore Plus(int value, FrameList frames);
        int Value { get; }
        string Print();
    }
}