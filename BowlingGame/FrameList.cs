using System;
using System.Collections.Generic;
using System.Linq;

namespace BowlingGame
{
    public class FrameList
    {
        private readonly List<IFrame> _frames;

        public FrameList(List<IFrame> frames = null)
        {
            _frames = frames ?? new List<IFrame>();
        }

        public override string ToString()
        {
            return string.Join(",", Array.ConvertAll(_frames.ToArray(), frame => frame.ToString()));
        }

        public FrameList Add(IFrame frame)
        {
            _frames.Add(frame);
            return new FrameList(_frames);
        }
    }
}