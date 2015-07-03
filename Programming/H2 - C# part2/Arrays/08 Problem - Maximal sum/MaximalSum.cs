/*Problem 8. Maximal sum

Write a program that finds the sequence of maximal sum in given array.
Example:

input	                                result
2, 3, -6, -1, 2, -1, 6, 4, -8, 8	    2, -1, 6, 4
   5  -1) -7) 1   0) 5  9   1)                      \= 11
Can you do it with only one loop (with single scan through the elements of the array)?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalSum
{
    static void Main()
    {
        //input	                                                     result
        //2, 3, -6, -1, 2, -1, 6, 4, -8, 8	                         2, -1, 6, 4 
        //22, -11, 1, 4, -8, 2, 3, 9, 64, -25, 12, 7, 6, 5           2, 3, 9, 64
        /**/
        Console.WriteLine("Maximal sum in given array (subarray).");
        Console.Write("Write elements: ");
        int[] someArray = Console.ReadLine().Split(new char[] { ',' }).Select(x => int.Parse(x)).ToArray();
        /**/

        /*
        int[] someArray = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        /**/

        int size = someArray.Length;

        int index = 0;
        int count = 1;
        int maxSum = int.MinValue;
        //int sum = 0;
        //int numOfElements = 1;
        //for (int i = 1; i < size - 1; i++)
        //{
        //    if (sum + someArray[i] > 0)
        //    {
        //        sum += someArray[i];
        //        ++count;
        //    }
        //    else if (sum + someArray[i] < 0)
        //    {
        //        numOfElements = count;
        //        sum = 0;
        //        index = i;
        //        count = 1;
        //    }
        //
        //    if (sum > maxSum)
        //    {
        //        index = i;
        //        maxSum = sum;
        //        Console.Write("Maximal subarray sum = {0} ", maxSum);
        //    }
        //}

        for (int i = 0; i < size; i++)
        {
            int sum = 0;
            int tempCount = 1;
            for (int j = 1; j <= size; j++)
            {
                if (i + j > size) break;
        
                sum += someArray[i + j - 1];
                if (sum > maxSum)
                {
                    count = tempCount;
                    index = i;
                    maxSum = sum;
                }
                tempCount++;
            }
        }

        Console.Write("Maximal subarray sum = {0} ", maxSum);
        Console.WriteLine();
        Console.WriteLine("Subarray: ");
        for (int i = index; i < index + count; i++)
        {
            Console.Write(" {0}", someArray[i]);
        }
        Console.WriteLine();




        /*
        int[] someArray = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int size = someArray.Length;

        int bestSum = 0;
        int index = 0;
        int startIndex = 0;
        int currentSum = 0;
        int previousSum = 0;
        int count = 1;
        int tempCount = 1;
        int sum = 0;

        for (int i = 1; i < size - 1; i++)
        {
            previousSum = someArray[i - 1] + someArray[i];
            currentSum = someArray[i] + someArray[i + 1];
            //0  1   2   3  4   5  6  7   8  9
            //2, 3, -6, -1, 2, -1, 6, 4, -8, 8
            if (i <= 1) //prisvoqvame pyrvata suma
            {
                sum = previousSum;
                bestSum = sum;
            }

            //best sum
            if (bestSum < sum)      //tempCount > count && 
            {
                count = tempCount;
                bestSum = sum;
            }
            
            if (tempCount >= 1)
            {
                sum = previousSum;
            }
            //0    1   2  3   4   5  6  7   8     9   10  11 12 13
            //22, -11, 1, 4, -8,|>2, 3, 9, 64,<| -25, 12, 7, 6, 5
            if (previousSum < currentSum)  //sumata narastva
            {
                sum += someArray[i + 1];
                ++tempCount;
                index = i;
            }
            else //sumata NEraste   previusSum > sum
            {
                //2, 3, -6, -1,|>2, -1, 6, 4,<| -8, 8
                //count = tempCount;
                sum = previousSum;
                tempCount = 1;
                continue;
            }

            

        }

        Console.WriteLine("Best sum = {0}", bestSum);
        Console.WriteLine();
        for (int i = 0; i < count; i++)
        {
            Console.Write(" {0}", someArray[index - count + i - 1]);
        }
        Console.WriteLine();
        Console.WriteLine(" {0}", index);
        Console.WriteLine(" {0}", count);
         */
    }
}