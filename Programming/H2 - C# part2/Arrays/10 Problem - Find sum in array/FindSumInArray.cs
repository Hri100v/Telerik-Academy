/*Problem 10. Find sum in array

Write a program that finds in given array of integers a sequence of given sum S (if present).
Example:

array	                S	    result
4, 3, 1, 4, 2, 5, 8	    11	    4, 2, 5
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FindSumInArray
{
    static void Main()
    {
        Console.WriteLine("Find sum in an array.");
        Console.WriteLine("Demand sum: ");
        //int sumOfSearch = int.Parse(Console.ReadLine());
        //
        //Console.Write("Write elements: ");
        //int[] numArray = Console.ReadLine()
        //                                    .Split(new char[] { ',' })
        //                                    .Select(x => int.Parse(x))
        //                                    .ToArray();
        int[] numArray = { 4, 3, 1, 4, 2, 5, 8 };
        foreach (var item in numArray)
        {
            Console.Write(" {0}", item);
        }

        int sumOfSearch = 11;
        int size = numArray.Length;
        int index = 0;
        int count = 1;
        int tempCount = 1;
        bool haveThatSum = false;

        Console.WriteLine();
        for (int i = 0; i < size - 1; i++)
        {
            int sum = 0;
            int k = i;
            tempCount = 0;
            do
            {
                if (sum < sumOfSearch)
                {
                    
                    sum += numArray[k];
                }
                //4, 3, 1, 4, 2, 5, 8
                if (sum == sumOfSearch)
                {
                    index = k;
                    count = tempCount;
                    haveThatSum = true;
                    break;
                }

                if (k > size - 1 || sum > sumOfSearch)
                {
                    break;
                }
                k++;
                ++tempCount;
            } while (true);

            if (haveThatSum)
            {
                break;
            }
        }

        if (haveThatSum)
        {
            Console.WriteLine("Sum of {0} is in the sub-array", sumOfSearch);
            for (int i = index - count; i < index + 1; i++)
            {
                Console.Write(" {0}", numArray[i]);
            }
        }
        else
        {
            Console.WriteLine("NO that sum of {0} in the array", sumOfSearch);
        }
        Console.WriteLine();

        //Console.WriteLine("{0}", count);
        //Console.WriteLine(index);
        //Console.WriteLine(haveThatSum);
       
    }
}