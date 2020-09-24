namespace BowlingGame
{
    public class Bonus : IBonus
    {
        private readonly int _value;

        public Bonus(in int value)
        {
            _value = value;
        }

        public IScore Add(IScore score)
        {
            return new Score(score.Value + _value);
        }
    }

    public interface IBonus
    {
        IScore Add(IScore score);
    }
}