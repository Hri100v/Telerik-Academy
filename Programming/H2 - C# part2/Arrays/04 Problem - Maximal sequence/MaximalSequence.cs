/*Problem 4. Maximal sequence

Write a program that finds the maximal sequence of equal elements in an array.
Example:

input	                        result
2, 1, 1, 2, 3, 3, 2, 2, 2, 1	2, 2, 2
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class MaximalSequence
{
    static void Main()
    {
        Console.WriteLine("Enter sequence: ");
        List<int> intList = new List<int>();
        //int n = int.Parse(Console.ReadLine());
        string inputStr = "2, 1, 1, 2, 3, 3, 2, 2, 2, 1"; //Console.ReadLine();
        string[] inputArray = inputStr.Split(',').Where(x => !string.IsNullOrEmpty(x)).ToArray();
        //string[] test = test.Where(x => !string.IsNullOrEmpty(x)).ToArray();
        //s.RemoveAll(str => String.IsNullOrEmpty(str));

        int size = inputArray.Length;
        int count = 0;
        int tempCount = 0;
        int indexRepited = 0;

/*        
        

        for (int i = 0; i < size - 1; i++)
        {
            count = 0;
            for (int j = size / 2 + 1; j >= 0; j--)
            {
                if (inputArray[i] == inputArray[j]);
                {
                    ++count;
                }

            }
            if (tempCount < count)
            {
                tempCount = count;
                indexRepited = i;
            }
        }

        Console.WriteLine("the maximal sequence of equal elements in an array are:");
        for (int f = 0; f < tempCount; f++)
        {
            Console.WriteLine("\"{0} \"", inputArray[f]);
        }
*/

        int[] intArray = new int[size];
        for (int i = 0; i < inputArray.Length - 1; i++)
        {
            intArray[i] = int.Parse(inputArray[i]);
            Console.WriteLine(intArray[i]);
        }

        for (int i = 0; i < size - 1; i++)
        {
            count = 0;
            for (int j = size / 2 + 1; j >= 0; j--)
            {
                if (intArray[i] == intArray[j])
                {
                    ++count;
                }

            }
            if (tempCount < count)
            {
                tempCount = count;
                indexRepited = i;
            }
        }
        Console.WriteLine("the maximal sequence of equal elements in an array are:");
        for (int f = 0; f < tempCount; f++)
        {
            if (f != tempCount - 1)
            {
                Console.Write("\"{0}\",", intArray[indexRepited]);
            }
            else
            {
                Console.WriteLine("\"{0}\"", intArray[indexRepited]);
            }
            
        }
        
    }
}