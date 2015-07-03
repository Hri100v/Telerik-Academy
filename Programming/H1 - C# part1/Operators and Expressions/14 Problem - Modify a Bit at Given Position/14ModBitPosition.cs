/*Problem 14. Modify a Bit at Given Position

We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving 
all other bits in n.
Examples:

n	    binary representation of n	    p	v	binary result	    result
5	    00000000 00000101	            2	0	00000000 00000001	1
0	    00000000 00000000	            9	1	00000010 00000000	512
15	    00000000 00001111	            1	1	00000000 00001111	15
5343	00010100 11011111	            7	0	00010100 01011111	5215
62241	11110011 00100001	            11	0	11110011 00100001	62241
 */

using System;

    class ModBitPosition
    {
        static void Main()
        {

            Console.WriteLine("Modify a Bit at Given Position");
            Console.WriteLine("Enter some number: ");
            string num = Console.ReadLine();
            ushort a = ushort.Parse(num);
            Console.Write("Binary representation of {0} is: ", num);
            Console.WriteLine(Convert.ToString(a, 2).PadLeft(8, '0'));

            Console.WriteLine("Change bit position #: ");
            string strP = Console.ReadLine();
            ushort p = ushort.Parse(strP);

            ushort v;
            do
            {
                Console.WriteLine("With bit (0 or 1) : ");
                string strV = Console.ReadLine();
                v = ushort.Parse(strV);
                Console.WriteLine();
            } while (v == 1 && v == 0);

            //int p = 0;
            int mask = 1 << p;
            int AndMask = a & mask;
            //Console.WriteLine(AndMask);
            int bitP = AndMask >> p;    //know bit on position p
            //int mask0 = 0 << p;
            int mask1 = 1 << p;

            int changeMask;
/*
            changeMask = ~a ^ mask1;
            changeMask = ~changeMask;
            Console.WriteLine(Convert.ToString(changeMask, 2).PadLeft(8, '0'));
            Console.WriteLine(changeMask);
            */

           
                        if (v == 0 && bitP == 1)
                        {
                            changeMask = ~a | mask1;
                            changeMask = ~changeMask;
                            Console.Write("binary result: ");
                            Console.WriteLine(Convert.ToString(changeMask, 2).PadLeft(8, '0'));
                            Console.Write("result: ");
                            Console.WriteLine(changeMask);
                        }
                        else if (v == 1 && bitP == 0)
                        {
                            changeMask = ~a ^ mask1;
                            changeMask = ~changeMask;
                            Console.Write("binary result: ");
                            Console.WriteLine(Convert.ToString(changeMask, 2).PadLeft(8, '0'));
                            Console.Write("result: ");
                            Console.WriteLine(changeMask);
                        }
                        else
                        {
                            Console.Write("binary result: ");
                            Console.WriteLine(Convert.ToString(a, 2).PadLeft(8, '0'));
                            Console.Write("result: ");
                            Console.WriteLine(a);
                        }
             
        }
    }