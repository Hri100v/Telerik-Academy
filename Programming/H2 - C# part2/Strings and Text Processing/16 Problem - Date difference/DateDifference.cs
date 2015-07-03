/*Problem 16. Date difference

Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
Example:

Enter the first date:   27.02.2006
Enter the second date:  3.03.2006
Distance: 4 days
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _16_Problem___Date_difference
{
    class DateDifference
    {
        static void Main(string[] args)
        {
            string firstDate = "27.02.2006";
            string secondDate = "3.03.2006";
            //string firstDate = Console.ReadLine();
            //string secondDate = Console.ReadLine();
            

            string format = "d.MM.yyyy";

            DateTime startDate = DateTime.ParseExact(firstDate, format, CultureInfo.InvariantCulture);
            DateTime finishDate = DateTime.ParseExact(secondDate, format, CultureInfo.InvariantCulture);

            var result = (finishDate - startDate).TotalDays;
            Console.WriteLine("Distance: {0}", result);

        }
    }
}
