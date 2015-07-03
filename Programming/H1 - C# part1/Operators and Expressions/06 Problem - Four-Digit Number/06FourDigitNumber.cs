/*Problem 6. Four-Digit Number

Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.

Examples:

n	    sum of digits	reversed	last digit in front	    second and third digits exchanged
2011	4	            1102	    1201	                2101
3333	12	            3333	    3333	                3333
9876	30	            6789	    6987	                9786
 */

using System;

    class FourDigitNumber
    {
        static void Main()
        {
            Console.WriteLine("Write four-digit number :");
            ConsoleKeyInfo key1 = Console.ReadKey();
            ConsoleKeyInfo key2 = Console.ReadKey();
            ConsoleKeyInfo key3 = Console.ReadKey();
            ConsoleKeyInfo key4 = Console.ReadKey();

            Console.WriteLine();
            //format abcd
            //A
            char charA = Convert.ToChar(key1.KeyChar);
            //Console.WriteLine(charA);
            string strA = Convert.ToString(charA);      //can`t cast char to int directly because give different value
            //Console.WriteLine(strA);
            int A = int.Parse(strA);
            //Console.WriteLine(A+3);

            //B
            char charB = Convert.ToChar(key2.KeyChar);
            string strB = Convert.ToString(charB);
            int B = int.Parse(strB);

            //C
            char charC = Convert.ToChar(key3.KeyChar);
            string strC = Convert.ToString(charC);
            int C = int.Parse(strC);

            //D
            char charD = Convert.ToChar(key4.KeyChar);
            string strD = Convert.ToString(charD);
            int D = int.Parse(strD);

            //sum of the digits
            Console.WriteLine("sum of the digits is {0}", (A + B + C + D));

            //reversed order: dcba
            Console.WriteLine("reversed order {3}{2}{1}{0}", A, B, C, D);

            //dabc  the last digit in the first position
            Console.WriteLine("the last digit in the first position {3}{0}{1}{2}", A, B, C, D);

            //acbd
            Console.WriteLine("exchanges the second and the third digits {0}{2}{1}{3}", A, B, C, D);
        }
    }
