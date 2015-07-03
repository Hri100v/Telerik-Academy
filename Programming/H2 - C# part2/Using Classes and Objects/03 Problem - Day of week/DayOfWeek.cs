/*Problem 3. Day of week

Write a program that prints to the console which day of the week is today.
Use System.DateTime.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemDayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Today {0:dd/MM/yyyy} is [{1}]", DateTime.Now, DateTime.Now.DayOfWeek);  // (dddd / ... , , Encoding.GetEncoding(1251))
        }
    }
}
