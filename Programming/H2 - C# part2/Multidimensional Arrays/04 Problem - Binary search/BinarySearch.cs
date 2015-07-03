/*Problem 4. Binary search

Write a program, that reads from the console an array of N integers and an integer K, 
sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Problem___Binary_search
{
    class BinarySearch
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Please enter the numbers N of array: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter K to compare with elements is '≤ K': ");
            int k = int.Parse(Console.ReadLine());

            //declere array N
            int[] arrayN = new int[n];
            Console.WriteLine("Please enter {0} numbers in array.", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("array[{0}] = ", i);
                arrayN[i] = int.Parse(Console.ReadLine());                
            }

            //check for have an element less then k
            if (arrayN[0] > k)
            {
                Console.WriteLine("There are not have number equal or less than K");
            }

            //sort array
            Array.Sort(arrayN);

            //find maximal close number to k
            int MaxValLessK = 0;
            //bool haveIt = true;
            for (int i = 0; i < n; i++)
            {
                if (arrayN[i] <= k)
                {
                    MaxValLessK = arrayN[i];
                }
                else
                {
                    //haveIt = false;
                    break;      
                } 
            }

            //binary search method
            int index = Array.BinarySearch(arrayN, MaxValLessK);
            
            //printing
            Console.WriteLine("Maximal number equal or less than K is array[{0}] = {1}", index, arrayN[index]);
            Console.WriteLine();
        }
    }
}
