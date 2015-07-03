/*
 * Problem 14.* Current Date and Time
    Create a console application that prints the current date and time. Find out how in Internet.
 */

using System;


    class printDateTimeNow
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(dateOnly.ToString("MM/dd/yyyy HH:mm"));

            DateTime saveDataTimeNow = DateTime.Now;
            Console.WriteLine("Current date & time is " + saveDataTimeNow.ToString("dd/MM/yyyy HH:mm:ss"));

            //DateTime thisDate = new DateTime(2008, 3, 15);
            //DateTimeFormatInfo fmt = (new CultureInfo("hr-HR")).DateTimeFormat;
            //Console.WriteLine(thisDate.ToString("d", fmt));      
        }
    }

