/*Problem 5. Sort by string length

You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Problem___Sort_by_string_length
{
    class SortStringLength
    {
        static void Main()
        {
            //filling array of strings
            /**/
            Console.Write("Please enter the numbers N of array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter consecutively elements of array.");
            string[] arrayStr = new string[n];

            for (int elem = 0; elem < arrayStr.GetLength(0); elem++)
            {
                Console.Write("Please enter array[{0}]: ", elem);
                arrayStr[elem] = Console.ReadLine();
            }
            /**/
            //string[] arrayStr = { "a", "Albano", "cool", "brush", "some", "else", };
            int size = arrayStr.Length;

            string[] sortedArrayStr = new string[arrayStr.GetLength(0)];
            Array.Copy(arrayStr, sortedArrayStr, arrayStr.GetLength(0));
            Array.Sort(sortedArrayStr);
            Array.Sort(sortedArrayStr, (x,y) => x.Length.CompareTo(y.Length));

            
            //string tempString = "";
            //foreach (var item in arrayStr)
            //{
            //    //Console.Write(" {0}", item);
            //    int lengthItem = item.Length;
            //    int i = Array.IndexOf(arrayStr, item);
            //    while (sortedArrayStr[i] != sortedArrayStr[size - 1])
            //    {
            //        if (item.Length > sortedArrayStr[i].Length)
            //        {
            //            tempString = sortedArrayStr[i];
            //        }
            //        ++i;
            //        if (sortedArrayStr[i] == sortedArrayStr[size - 1]) break;
            //    }
            //    int j = 0;
            //    sortedArrayStr[j] = tempString;
            //    ++j;
            //}

            PrintArray(sortedArrayStr);

            Console.WriteLine();
        }

        private static void PrintArray(string[] sortedArrayStr)
        {
            Console.WriteLine();
            foreach (var item in sortedArrayStr)
            {
                Console.Write("{0} ", item);
            }
        }
        /*
        private static string[] SortArrayLength(string[] someStringArray)
        { 
            
        }*/
    }
}
