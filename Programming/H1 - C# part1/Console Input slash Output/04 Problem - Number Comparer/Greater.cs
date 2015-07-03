/*Problem 4. Number Comparer

Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.
Examples:

a	    b	    greater
5	    6	    6
10	    5	    10
0	    0	    0
-5	    -2	    -2
1.5	    1.6	    1.6
 */

using System;

    class Greater
    {
        static void Main()
        {
            Console.WriteLine("Salute!");
            Console.Write("Please write number: ");
            float num1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Please write second number: ");
            float num2 = Convert.ToSingle(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(num1 + " or " + num2 + " \nGreater is ");
            Console.WriteLine(num1>num2 ? num1 : num2);
        }
    }
