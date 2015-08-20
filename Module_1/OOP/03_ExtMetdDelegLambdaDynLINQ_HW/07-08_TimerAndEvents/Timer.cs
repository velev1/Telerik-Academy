// Problem 7. Timer
// Using delegates write a class Timer that can execute certain method at each t seconds.

namespace TimerAndEvents
{
    using System;
    using System.Threading;

    public delegate void TimerAction(string text);

    public class Timer
    {
        private TimerAction action;

        public Timer(int tickCount, int interval, TimerAction action)
        {
            this.Interval = interval;
            this.TicksCount = tickCount;
            this.action = action;
        }
        
        public int Interval { get; set; }
        public int TicksCount { get; set; }

        public void Run()
        {
            while (this.TicksCount > 0)
            {
                this.action(this.TicksCount.ToString());
                Thread.Sleep(this.Interval);
                this.TicksCount--;
            }
        }
    }
}
