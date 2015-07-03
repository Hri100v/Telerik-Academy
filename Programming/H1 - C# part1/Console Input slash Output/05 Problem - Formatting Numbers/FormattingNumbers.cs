/*Problem 5. Formatting Numbers

Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.
Examples:

a	b	    c	        result
254	11.6	0.5	        FE   |0011111110    | 11.60|0.500       |
499	-0.5559	10000	    1F3  |0111110011    | -0.56|10000.000   |
0	3	    -0.1234	    0    |0000000000    |     3|-0.123      |
 */

using System;

    class FormattingNumbers
    {
        static void Main()
        {
            Console.WriteLine("Salute!");
            Console.Write("Please write integer number one (0 <= num <= 500)");
            int num1;
            do
            {
                Console.WriteLine("Please enter correct integer number (0 <= num <= 500)");
                num1 = Convert.ToInt32(Console.ReadLine());

            } while (!(num1 >= 0 && num1 <= 500));

          
            Console.Write("Please write number two: ");
            float num2 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Please write number three: ");
            float num3 = Convert.ToSingle(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("{0,8} | {1,8} | {2,8} | {3,18} | {4,23} |", "a", "b", "c", "result a", "result b & c");
            Console.WriteLine("{0,-8} | {1,-8} | {2,-8} | {3,-5:X} | {4,-10} | {5,10:F2} | {6,-10:0.000} |", 
                                num1,   num2,   num3,    num1,      Convert.ToString(num1, 2).PadLeft(10, '0'), num2, num3);
           
        }
    }
