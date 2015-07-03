/*Problem 16.* Subset with sum S

We are given an array of integers and a number S.
Write a program to find if there exists a subset of the elements of the array that has a sum S.
Example:

input array	                S	    result
2, 1, 2, 4, 3, 5, 2, 6	    14	    yes
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16asteriks_Problem___Subset_with_sum_S
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] inputArray = { 2, 1, 2, 4, 3, 5, 2, 6 };                 //in the example sub-array is 1 2 5 6 but have - 2 1 2 4 5;  3 5 6
            int[] inputArray = { -1, 4, 3, 8, 0, 2, 4, 5, 6 };      
            int len = inputArray.Length;
            int sum = 6;
            //bool haveSum = false;
            //int tempSum = 0;
            int startFrom = 1;

            

            //List<int> left = new List<int>();
            //left.Add(inputArray[3]);
            //left.Add(inputArray[4]);
            //left.Add(inputArray[7]);
            //left.RemoveAt(0);
            //int trySum = left.Sum();
            //Console.WriteLine(trySum);
            
            List<int> usedN = new List<int>();
            List<int> unusedN = new List<int>();
            usedN.Add(inputArray[0]);
            int sumOfDecision = usedN.Sum();
            unusedN= inputArray.ToList();
            unusedN.RemoveAt(0);            //unusedN.RemoveAt(startFrom);

            Console.WriteLine();

            //int i = 0;
            while (sum != sumOfDecision)
            {
                if (sum > sumOfDecision)
                {
                    usedN.Add(unusedN[0]);
                    sumOfDecision = usedN.Sum();
                    unusedN.RemoveAt(0);
                }
                else //if (sum < sumOfDecision)
                {
                    unusedN.Add(usedN[usedN.Count - 1]);
                    usedN.RemoveAt(usedN.Count - 1);
                    sumOfDecision = usedN.Sum();
                }

                //++i;
            }

            foreach (var item in usedN)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("The sum is {0}", usedN.Sum());
            Console.WriteLine();
        }
    }
}
