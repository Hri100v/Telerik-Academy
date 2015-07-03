/*Problem 14. Quick sort

Write a program that sorts an array of strings using the Quick sort algorithm.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Problem___Quick_sort
{
    class QuickSort
    {
        static void Main()
        {

           //Console.WriteLine("Enter numbers: ");
           //int[] someArray = Console.ReadLine()
           //                                    .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
           //                                    .Select(x => int.Parse(x))
           //                                    .ToArray();


            int[] someArray = { 64, 25, 12, 22, 11, 1, 4, 8, 2, 3, 9, 7, 6, 5 };
            Console.WriteLine("Some unSorted array.");
            for (int i = 0; i < someArray.Length; i++)
            {
                Console.Write(someArray[i] + " ");
            }
            Console.WriteLine();
            int[] unSort = new int[someArray.Length];
            for (int i = 0; i < someArray.Length; i++)
            {
                unSort[i] = someArray[i];
            }
            Console.WriteLine();

            ArrayQSort(unSort, 0, unSort.Length - 1);

            Console.WriteLine("Quick Sorted array.");
            foreach (var item in unSort)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static void ArrayQSort(int[] number, int left, int right)
        {
            int i = left;
            int j = right;
            IComparable pivot = number[(left + right) / 2];
            while (i <= j)
            {
                while (number[i].CompareTo(pivot) < 0) i++;
                while (number[j].CompareTo(pivot) > 0) j--;

                if (i <= j)
                {
                    int tempN = number[i];
                    number[i] = number[j];
                    number[j] = tempN;

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                ArrayQSort(number, left, j);
            }

            if (right > i)
            {
                ArrayQSort(number, i, right);
            }
        }
    }
}
