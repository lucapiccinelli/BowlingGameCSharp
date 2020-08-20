namespace BowlingGame
{
    public class NormalFrame : IFrame
    {
        private readonly Roll _firstRoll;
        private readonly Roll _secondRoll;

        public NormalFrame(Roll firstRoll, Roll secondRoll)
        {
            _firstRoll = firstRoll;
            _secondRoll = secondRoll;
        }

        public Score Score => new Score(_firstRoll.Value, this).Plus(_secondRoll);

        public override string ToString()
        {
            return Score.ToString();
        }
    }
}