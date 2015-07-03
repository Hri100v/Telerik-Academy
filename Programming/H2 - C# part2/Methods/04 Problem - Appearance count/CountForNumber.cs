/*Problem 4. Appearance count

Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Problem___Appearance_count
{
    class CountForNumber
    {
        static void Main()
        {
            Console.WriteLine("Write array of integer.");
            Console.WriteLine("Write element one by one separate with 'Enter'. \nFor Quit enter something else of number.");
            string input;
            List<int> array = new List<int> ();
            //int index = 0;
            while (true)
            {
                input = Console.ReadLine();
                int num;
                if (int.TryParse(input, out num))
                {
                    array.Add(num);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Write some number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            //PrintList(array);

            //int number = 5;
            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 55, 15, 5, 13, 2, 3, 7, 5 };       // 5 - (3 times)
            //List<int> array = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 55, 15, 5, 13, 2, 3, 7, 5 };

            Console.WriteLine();
            Console.Write("Number {0} apper {1} time(s) in given array. \n", number, CountAppearsOfNumber(array, number));
            //Console.WriteLine(CountAppearsOfNumber(array, number));
        }

        private static void PrintList(List<int> array)
        {
            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }
        }
        static int CountAppearsOfNumber(List<int> someArray, int searchingNumber)
        {
            int count = 0;

            for (int i = 0; i < someArray.Count; i++)
            {
                if (someArray[i] == searchingNumber)
                {
                    ++count;
                }
            }

            return count;
        }
    }
}
