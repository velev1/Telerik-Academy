namespace TimerAndEvents
{
    using System;
    using System.Threading;

    public class TimerAndEventsTestingArea
    {
        public static void Main()
        {
            TimerAction testDelegate = new TimerAction(PrintSmtDeleg);

            Timer delegateTimer = new Timer(10, 100, testDelegate);
            delegateTimer.Run();

            Console.WriteLine();
            EventTimer evTimer = new EventTimer(10, 100);
            evTimer.NextEvent += PrintSmt;
            evTimer.RunTimer();
        }

        private static void PrintSmtDeleg(string text)
        {
            Console.WriteLine("Timer (delagate) ticks left {0}", text);
        }

        private static void PrintSmt(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("ticks event");
        }
    }
}
