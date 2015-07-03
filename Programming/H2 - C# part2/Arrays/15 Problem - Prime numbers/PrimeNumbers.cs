/*Problem 15. Prime numbers

Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimeNumbers
{
    static void Main()
    {
        Console.WriteLine();
        int[] primeNArray = new int[40];
        int size = primeNArray.Length;
        for (int i = 0; i < size; i++)
        {
            primeNArray[i] = i;
            //Console.Write(primeNArray[i] + " ");
        }

        //List<int> delimiter = new List<int>();
        //delimiter[0] = 2;
        //delimiter[1] = 4;
        //delimiter[2] = 6;
        bool[] marked = new bool[size];
        for (int i = 0; i < size; i++)
        {
            marked[i] = true;
        }

        for (int i = 2; i < size; i++)
        {
            if (marked[i] == true)
            {
                int j = i + 1;
                while (j < size)
                {
                    if (j % i == 0)
                    {
                        marked[j] = false;
                    }
                    ++j;
                }
            }
        }

        for (int i = 0; i < size; i++)
        {
            if (marked[i])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(primeNArray[i] + " ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(primeNArray[i] + " ");
            }
            //Console.WriteLine(i + "-->" + marked[i]);
        }

        //for (int i = 0; i < size; i++)
        //{
        //    Console.Write(primeNArray[i] + " --> " + marked[i]);
        //    Console.WriteLine();
        //}



        //foreach (var item in delimiter)
        //{
        //    Console.Write(item+ " ");
        //}


        //int index = Array.BinarySearch(primeNArray, 3);
        //Console.Write(index);

        Console.WriteLine();
    }

    private static void PrintArray(int[] primeNArray)
    {
        foreach (int num in primeNArray)
        {
            Console.Write(num + " ");
        }
    }
}