/*Problem 3. Range Exceptions

 * Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
It should hold error message and a range definition [start … end].

 * Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] 
and dates in the range [1.1.1980 … 31.12.2013].
 
 */

namespace _03_Problem___Range_Exceptions
{
    using System;

    class Program
    {
        static void Main()
        {
            // int [1..100]
            {
                try
                {
                    int start = 1;
                    int end = 100;

                    int testX = 101;
                    Console.WriteLine("Test with param = " + testX);


                    if (!(start < testX && testX < end))
                    {
                        throw new InvalidRangeException<int>(start, end);
                    }

                }
                catch (InvalidRangeException<int> exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine("Start: " + exception.Start + "; End: " + exception.End);
                }
            }

            Console.WriteLine();
            Console.WriteLine("# # #");
            Console.WriteLine();

            // DateTime range [1.1.1980 … 31.12.2013]
            {
                try
                {
                    DateTime start = new DateTime(1980, 1, 1);
                    DateTime end = new DateTime(2013, 12, 31);

                    //DateTime testDateTime = new DateTime(1979, 12, 31);
                    DateTime testDateTime = DateTime.MinValue;

                    if (!(start < testDateTime && testDateTime < end))
                        throw new InvalidRangeException<DateTime>(start, end);

                }
                catch (InvalidRangeException<DateTime> exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine("Start: " + exception.Start + "; End: " + exception.End);
                }
            }

        }
    }
}
