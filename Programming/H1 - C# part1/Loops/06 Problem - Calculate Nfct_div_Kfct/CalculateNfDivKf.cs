/*Problem 6. Calculate N! / K!

Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.
Examples:

n	k	n! / k!
5	2	60
6	5	6
8	3	6720
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

    class CalculateNfDivKf
    {
        static void Main()
        {
            Console.WriteLine("Calculates n! / k! (1 < k < n < 100). Write value for n after this for k.");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger nF = 1;
            BigInteger kF = 1;
            BigInteger result;

            if (k < 1 && n < k && n > 100)
            {
                 Console.WriteLine("Wrong data entry.");
            }

            for (int i = 1; i <= n; i++)
            {
                nF = nF * i;
                if (i <= k)
                {
                    kF = kF * i;
                }
            }
            result = nF / kF;
            //Console.WriteLine("N! = {0}", nF);
            //Console.WriteLine("K! = {0}", kF);
            Console.WriteLine("N! / K! = {0}", result);
        }
    }