/*Problem 9. Sorting array

Write a method that return the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9SortingArray
{
    class SortedArray
    {
        static void Main()
        {
            int[] arrayOfInteger = {1, 22, 32,42, -10, -11, -2, 123, 2, 5,3,55,57,53,64,51,97,-1,0 };
            PrintArrayInt(arrayOfInteger);
            
            //ascending
            Console.WriteLine("Ascending order: ");
            var ascendingArray = AscendingOrder(arrayOfInteger);
            PrintArrayInt(ascendingArray);
            Console.WriteLine();

            //desscending
            Console.WriteLine("Descending order: ");
            var descendingArray = DescendingOrder(arrayOfInteger);
            PrintArrayInt(descendingArray);

            Console.WriteLine();
        }

        ///\/\/\/\/\/\/\/\/\/\/\/\Method - Print/\/\/\/\/\/\/\/\/\/\/\/\/\\\
        static void PrintArrayInt(int[] someArrInt)
        {
            Console.WriteLine(String.Join(", ", someArrInt));
                  
        }

        ///\/\/\/\/\/\/\/\/\/\/\/\ Method - ascending /\/\/\/\/\/\/\/\/\/\/\/\/\\\
        static int[] AscendingOrder(int[] array)
        {
            int[] sortedArray = array.OrderBy(x => x).ToArray();
            return sortedArray;
        }

        ///\/\/\/\/\/\/\/\/\/\/\/\ Method - descending /\/\/\/\/\/\/\/\/\/\/\/\/\\\
        static int[] DescendingOrder(int[] array)
        {
            int[] sortedArray = array.OrderByDescending(x => x).ToArray();
            return sortedArray;
        }
    }
}
