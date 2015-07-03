/*Problem 5. Workdays

Write a method that calculates the number of workdays between today and given date, passed as parameter.
Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemWorkdays
{
    class Workdays
    {
        static List<DateTime> publicHolidays;
        static List<DateTime> extraDateWork;
        const string dateFormat = "dd/MM/yyyy";


        static void Main(string[] args)
        {
            //public holidays
            publicHolidays = new List<DateTime>
                                                    {   //mart
                                                        new DateTime(2015, 3, 2),
                                                        new DateTime(2015, 3, 3),
                                                    };

            //list for working days out of time
            extraDateWork = new List<DateTime>
                                                    {   //mart
                                                        new DateTime(2015, 3, 21),
                                                    };

            //*************************************************************************** 

            //DateTime dateNow = DateTime.Now.Date;
            DateTime dateNow = new DateTime(2015, 02, 25);

            DateTime dateForTest = new DateTime(2015, 03, 28);
            //Console.WriteLine(dateForTest);

            Console.WriteLine("How much day(s) have from {0} to {1}", dateNow.ToString(dateFormat), dateForTest.ToString(dateFormat));
            CountWorkDay(dateNow, dateForTest);

        }

        private static void CountWorkDay(DateTime dateNow, DateTime dateCheck)
        {
            //because now is before tomorrow ;)
            int workDays = 0;
            DateTime thisMoment = dateNow;
            while (thisMoment <= dateCheck)
            {
                if (!publicHolidays.Contains(thisMoment))       //&& !extraDateWork.Contains(thisMoment)
                {
                    ++workDays;
                }
                
                if ((int)thisMoment.DayOfWeek == 0 || (int)thisMoment.DayOfWeek == 6)
                {
                    --workDays;
                }
                
                if (extraDateWork.Contains(thisMoment))
                {
                    ++workDays;
                }

                //Console.WriteLine("{0} -> {1} day of week",thisMoment.ToString(dateFormat), (int)thisMoment.DayOfWeek);

                thisMoment = thisMoment.AddDays(1);
            }

            Console.WriteLine("Work days = {0}", workDays);
        }
    }
}

///compare method
//if (0 > DateTime.Compare(dateNow, publicHolidays[0]))   //compare -1 0 1
//{
//    Console.WriteLine("{0} Before {1}", dateNow.ToString(dateFormat), publicHolidays[0].ToString(dateFormat));
//}
//else if (0 == DateTime.Compare(dateNow, publicHolidays[0]))
//{
//    Console.WriteLine("{0} equal {1}", dateNow.ToString(dateFormat), publicHolidays[0].ToString(dateFormat));
//}
//else
//{
//    Console.WriteLine("{0} After {1}", dateNow, publicHolidays[0]);
//}