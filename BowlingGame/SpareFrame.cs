﻿namespace BowlingGame
{
    public class SpareFrame : IFrame
    {
        private readonly BowlingRolls _bowlingRolls;
        private readonly Roll _firstRoll;
        private readonly Roll _secondRoll;

        public SpareFrame(BowlingRolls bowlingRolls, Roll firstRoll, Roll secondRoll)
        {
            _bowlingRolls = bowlingRolls;
            _firstRoll = firstRoll;
            _secondRoll = secondRoll;
        }

        public Score Score()
        {
            return _bowlingRolls.AssignBonus(new Score(_firstRoll.Value).Plus(_secondRoll), 1);
        }
    }
}