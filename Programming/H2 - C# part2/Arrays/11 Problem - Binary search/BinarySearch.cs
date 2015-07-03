/*Problem 11. Binary search

Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinarySearch
{
    static void Main()
    {
        int[] firstArray = { 15, 3, 51, 17, 9, 11, 12, 34, 55 };
        Array.Sort(firstArray);
        foreach (var item in firstArray)
        {
            Console.Write(item + " ");
        }
        int firstI = firstArray[0];
        int lastI = firstArray[firstArray.Length - 1];
        int start = 0;
        int finish = firstArray.Length - 1 ;
        //Console.WriteLine(finish);
        int searchN = 11;
        int mid = (start + finish) / 2;
        Console.WriteLine();
        while (start != finish)
        {
            if (firstArray[mid] == searchN)
            {
                Console.WriteLine("searching number is {0} with index {1}", firstArray[mid], mid);
                return;
            }

            if (searchN < firstArray[mid])
            {
                finish = mid;
                mid = (start + mid + 1) / 2;
            }
            else
            {
                start = mid + 1;
                mid = (mid + finish - 1) / 2;
            }
        }
        Console.WriteLine();

        /*
        int[] firstArray = { 15, 3, 51, 17, 9, 11 };
        int sizeFirstA = firstArray.Length;
        Console.WriteLine("Enter the array of integer.");
        int[] secondArray = Console.ReadLine().Split(new char[] { ',' }).Select(x => int.Parse(x)).ToArray();

        Console.Write("Searching element (integer) is: ");
        int searchingInt = int.Parse(Console.ReadLine());
        int searchBinN = int.Parse(Convert.ToString(searchingInt, 2));
        Console.WriteLine("Searching element in binary - {0}", searchBinN);
        int sizeSecondA = secondArray.Length;

        int[] sortFArray = new int[sizeFirstA];
        int[] sortSArray = new int[sizeSecondA];
        //foreach (var item in firstArray)
        //{
        //    Console.Write("{0} ", item);
        //}
        Console.WriteLine();
        Array.Copy(firstArray, sortFArray, sizeFirstA);
        Array.Sort(sortFArray);
        Array.Copy(secondArray, sortSArray, sizeSecondA);
        Array.Sort(sortSArray);
        foreach (var item in sortSArray)
        {
            Console.Write("{0} ", item);
        }

        //binary represent
        long[] binarySSArray = new long[sizeSecondA];
        for (int i = 0; i < sizeSecondA; i++)
        {
            binarySSArray[i] = long.Parse(Convert.ToString(sortSArray[i], 2));
        }
        Console.WriteLine();
        Console.WriteLine("Binary represent the array");
        foreach (var item in binarySSArray)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
        int index = Array.IndexOf(binarySSArray, searchBinN);
        Console.WriteLine("Bin N({0}) - have index[{1}] in at sorted array", searchBinN, index);

         */
        Console.WriteLine();
    }
}