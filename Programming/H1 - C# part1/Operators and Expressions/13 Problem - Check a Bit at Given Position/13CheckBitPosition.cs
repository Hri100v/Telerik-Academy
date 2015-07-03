/*Problem 13. Check a Bit at Given Position

Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
Examples:

n	    binary representation of n	    p	bit @ p == 1
5	    00000000 00000101	            2	true
0	    00000000 00000000	            9	false
15	    00000000 00001111	            1	true
5343	00010100 11011111	            7	true
62241	11110011 00100001	            11	false
 */

using System;

    class CheckBitPosition
    {
        static void Main()
        {
            Console.WriteLine("Check bit # p == 1. Enter some number: ");
            string strA = Console.ReadLine();
            Console.WriteLine("Bit position #: ");
            string strP = Console.ReadLine();
            ushort p = ushort.Parse(strP);
            ushort a = ushort.Parse(strA);
            Console.WriteLine(Convert.ToString(a, 2).PadLeft(8, '0'));
            Console.WriteLine();

            int mask = 1 << p;
            int AndMask = a & mask;
            int bitP = AndMask >> p;
            bool isTrue = true;
            bool isFalse = false;
            Console.WriteLine((bitP & 1) == 1 ? isTrue : isFalse);
        }
    }