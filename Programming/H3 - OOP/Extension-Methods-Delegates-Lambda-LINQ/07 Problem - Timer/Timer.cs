using System;
using System.Threading;

namespace _07_Problem___Timer
{
    class Timer
    {
        public static void TakeTimeInterval(Action func, int interval)
        {
            while (true)
            {
                Thread.Sleep(interval * 1000);

                func();
            }
        }

        //public static void TimeNow()
        //{
        //    Console.WriteLine(DateTime.Now);
        //}
    }
}
