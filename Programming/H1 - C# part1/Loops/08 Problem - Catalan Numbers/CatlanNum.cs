/*Problem 8. Catalan Numbers

In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
Examples:

n	Catalan(n)
0	1
5	42
10	16796
15	9694845
 */

using System;
using System.Numerics;
using System.Text;

    class CatlanNum
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Write value for n (0 ≤ n ≤ 100) to be calculate Catalan(n).");
            int n = int.Parse(Console.ReadLine());
            BigInteger nF = 1;
            BigInteger n2F = 1;
            BigInteger nPlusOneF = 1;
            BigInteger result;

            // Catalan Formula - [ 2n! / ((n+1)! * n!) ]

            if (n < 0 && n > 100)
            {
                Console.WriteLine("Not correct data entry.");
            }

            for (int i = 1; i <= (2 * n); i++)
            {
                n2F = n2F * i;

                if (i <= n)
                {
                    nF = nF * i;
                }

                if (i <= (n + 1))
                {
                    nPlusOneF = nPlusOneF * i;
                }
                
            }


            // 2n! / ((n-1)! * n!)
            result = n2F / (nPlusOneF * nF);
            Console.WriteLine("2n! / ((n+1)! * n!) = {0}", result);

        }
    }