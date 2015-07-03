/*Problem 12. Extract Bit from Integer

Write an expression that extracts from given integer n the value of given bit at index p.
Examples:

n	    binary      representation	p	bit @ p
5	    00000000    00000101	    2	1
0	    00000000    00000000	    9	0
15	    00000000    00001111	    1	1
5343	00010100    11011111	    7	1
62241	11110011    00100001	    11	0
 */

using System;

    class ExtractBitFromInteger
    {
        static void Main()
        {

            Console.WriteLine("Enter some number: ");
            string strA = Console.ReadLine();
            Console.WriteLine("You want see bit #: ");
            string strP = Console.ReadLine();
            ushort p = ushort.Parse(strP);
            ushort a = ushort.Parse(strA);
            Console.WriteLine(Convert.ToString(a, 2).PadLeft(8, '0'));
            Console.WriteLine();

            int mask = 1 << p;
            int AndMask = a & mask;
            int bitP = AndMask >> p;
            Console.WriteLine("bit #{0} is {1}", p, bitP);

        }
    }
