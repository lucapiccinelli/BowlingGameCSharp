using System;
using System.Collections.Generic;
using System.Linq;

namespace BowlingGame
{
    public class FrameList
    {
        private readonly List<IFrame> _frames = new List<IFrame>();

        public override string ToString()
        {
            return string.Join(",", Array.ConvertAll(_frames.ToArray(), frame => frame.ToString()));
        }
    }
}