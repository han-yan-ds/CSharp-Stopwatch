using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        private TimeSpan Ticker { get; set; }
        private DateTime StartTime { get; set; }
        private bool _isRunning = false;

        public Stopwatch()
        {
            Ticker = TimeSpan.Zero;
        }

        public void Start()
        {
            if (!_isRunning)
            {
                _isRunning = true;
                StartTime = DateTime.Now;
            }
        }

        public TimeSpan Stop()
        {
            if (_isRunning)
            {
                _isRunning = false;
                Ticker += (DateTime.Now - StartTime);
            }
            return Ticker;
        }
    }
}