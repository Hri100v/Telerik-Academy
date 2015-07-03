/*Problem 9. Frequent number

Write a program that finds the most frequent number in an array.
Example:

input	                                    result
4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	    4 (5 times)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FrequentNumber
{
    static void Main()
    {
        /**/
        Console.WriteLine("The most frequent number in an array.");
        //Console.Write("Write elements: ");
        /*
        int[] numArray = Console.ReadLine()
                                            .Split(new char[] { ',' })
                                            .Select(x => int.Parse(x))
                                            .ToArray();
        /**/
        //4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3
        //0  1  2  3  4  5  6  7  8  9  10 11 12
       
        int[] numArray = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        foreach (int num in numArray)
        {
            Console.Write(num);
            Console.Write(" ");
        }
        Console.WriteLine();
        int sizeArr = numArray.Length;
        //int min = numArray.Min();
        //Console.WriteLine(min);
        //int max = numArray.Max();
        //Console.WriteLine(max);
        //Console.WriteLine(sizeArr);

        int count = 1;
        int tempCount = 1;
        bool checkFrequent = false;
        int index = 0;
        for (int i = 0; i < sizeArr - 1; i++)
        {
            int k = i + 1;
            tempCount = 1;
            while (!checkFrequent)
            {
                if (numArray[i] == numArray[k])
                {
                    tempCount++;
                }

                if (tempCount > count)
                {
                    count = tempCount;
                    index = k;
                }

                if (k >= sizeArr - 1)
                {
                    break;
                    //checkFrequent = true;
                }
                k++;
            }
        }
        Console.WriteLine("{0} ({1} times)",numArray[index], count);

        Console.WriteLine();

    }
}