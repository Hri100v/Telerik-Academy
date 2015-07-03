/*Problem 7. Timer

Using delegates write a class Timer that can execute certain method at each t seconds.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Problem___Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer.TakeTimeInterval(TimeNow, 1);
        }

        public static void TimeNow()
        {
            var time = DateTime.Now;
            Console.WriteLine(time);

            if (time.Second.Equals(0))
                Console.Beep();
        }

    }
}
