// Problem 8.* Events
// Read in MSDN about the keyword event in C# and how to publish events.
// Re-implement the above using .NET events and following the best practices.

namespace TimerAndEvents
{
    using System;
    using System.Threading;

    public class EventTimer
    {
        public EventTimer(int ticksCount, int interval)
        {
            this.TicksCount = ticksCount;
            this.Interval = interval;
        }

        public event EventHandler NextEvent;

        public int TicksCount { get; set; }
        public int Interval { get; set; }  

        public void RunTimer()
        {
            while (this.TicksCount > 0)
            {
                this.NextEvent(this, EventArgs.Empty);
                Thread.Sleep(this.Interval);
                this.TicksCount--;
            }
        }
    }
}
