/*Problem 7. Calculate N! / (K! * (N-K)!)

In combinatorics, the number of ways to choose k different members out of a group of n different elements 
(also known as the number of combinations) is calculated by the following formula: formula For example, 
there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
Try to use only two loops.
 * 
Examples:

n	k	n! / (k! * (n-k)!)
3	2	3
4	2	6
10	6	210
52	5	2598960
 */

using System;
using System.Numerics;

class CalcNfKfExpr
{
    static void Main()
    {
        Console.WriteLine("Calculates n! / (k! * (n-k)! (1 < k < n < 100).");
        Console.WriteLine("Write value for n, next for k.");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger nF = 1;
        BigInteger kF = 1;
        BigInteger nkF = 1;
        long varNK = n - k;
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
            if (i <= varNK)
            {
                nkF = nkF * i;
            }
        }
        //Console.WriteLine("N! = {0}", nF);
        //Console.WriteLine("K! = {0}", kF);
        //Console.WriteLine("(N-K)! = {0}", nkF);

        result = nF / (kF * nkF);
        Console.WriteLine("N! / (K! * (N-K)!) = {0}", result);
    }
}