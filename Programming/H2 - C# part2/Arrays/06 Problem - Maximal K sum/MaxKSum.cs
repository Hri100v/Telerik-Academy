/*Problem 6. Maximal K sum

Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.
 */

using System;

    class MaxKSum
    {
        static void Main()
        {
            //Console.WriteLine("Write two integer numbers N and K and an array of N elements from the console.");
            //Console.Write("Write N - number of elements: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("Write those K elements that have maximal sum: ");
            //int k = int.Parse(Console.ReadLine());
            int n = 7;       //if delete backslashes before ^
            int k = 2;       //if delete backslashes before ^
            int bestSum = int.MinValue;
            int bestNum = 0;
            int index = 0;


            Console.WriteLine("Write N array of numbers consecutively: ");
            //int[] arrayN = new int[n];
            //hardcore
            int[] arrayN = { 3, 2, 3, 4, 2, 2, 4 };
            Console.WriteLine();
            foreach (int num in arrayN)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("Fix K = {0}", k);
            
            for (int i = 0; i < arrayN.Length - k; i++)
            {
                for (int j = 1; j <= k; j++)
                {
                    int sum = arrayN[i];
                    sum += arrayN[i+j];
                    if (bestSum < sum)
                    {
                        bestSum = sum;
                        bestNum = arrayN[i];
                        index = i;
                    }
                }
            }

            //3, 2, 3, 4, 2, 2, 4
            //int index = Array.IndexOf(arrayN, bestNum);
            Console.WriteLine();

            for (int m = 0; m < k; m++)
            {
                if (m >= k - 1)
                {
                    Console.WriteLine("{0} - this is max sum = {1} of K el.", arrayN[index + k - 1], bestSum);
                    break;
                }
                Console.Write("{0}, ", arrayN[index + m]);
            }
            

        }
    }