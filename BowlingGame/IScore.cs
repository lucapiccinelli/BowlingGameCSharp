namespace BowlingGame
{
    public interface IScore
    {
        IScore Plus(IScore score);
        IScore Plus(int value, FrameList frames);
        FrameList Frames { get; }
    }
}