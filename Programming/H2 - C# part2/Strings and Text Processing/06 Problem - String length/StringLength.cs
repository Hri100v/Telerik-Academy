/*Problem 6. String length

Write a program that reads from the console a string of maximum 20 characters. 
If the length of the string is less than 20, the rest of the characters should be filled with *.
Print the result string into the console.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStringLength
{
    class StringLength
    {
        static void Main()
        {
            string line = "Write a program that reads from the console a string of maximum 20 characters.";
            //Console.WriteLine(line.Length.ToString().PadRight(20, '*'));
            //while (true)
            //{
            //    if (true)
            //    {
            //        
            //    }
            //}


            // another way
            var first20 = line.Take(20);
            var from21ToEnd = line.ToList().Skip(20).Take(line.Length).ToList();
            
            Console.Write(string.Join("", first20) + new string('*', line.Length));        // first20.PadRight(line.Length, '*')           line.PadRight(line.Length, '*')
            Console.WriteLine();
            //Console.WriteLine(new string ('*', line.Length));



            //test
            /*
            var resFirst20 = line.ToList().Skip(20).ToList();
            Console.WriteLine(string.Join("", resFirst20));        // resFirst20.ToString()
            var test = line.ToList().GetRange(0, 20);
            Console.WriteLine(string.Join(";", test));


            

            Console.WriteLine(line.Where(ch => ch > 20));



            
            List<float> myList = new List<float>();
            myList.Add(12.5F);
            myList.Add(13.5F);
            myList.Add(10.45F);
            myList.Add(12.30F);
            myList.Add(11.50F);
            myList.Add(11.15F);
            myList.Add(6.00F);
            myList.Add(9.15F);
            myList.Add(10.30F);

            var firstFiveItems = myList.Take(5);
            Console.WriteLine("All bus in list ->");
            Console.WriteLine(string.Join(" <> ", myList));

            Console.WriteLine();
            Console.WriteLine(string.Join(" <> ", firstFiveItems));

            var secondFiveItems = myList.Skip(5).Take(5);
            Console.WriteLine(string.Join(" <> ", secondFiveItems));

            //var firstFiveArrivals = myList.OrderBy(i => i.ArrivalTime).Take(5);
            */
        }
    }
}
