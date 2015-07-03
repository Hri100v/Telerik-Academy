/*
 * Problem 9. Exchange Variable Values
    Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by 
    using some programming logic.
    Print the variable values before and after the exchange.
 */

using System;

    class varExchange
    {
        static void Main()
        {
            Console.WriteLine("Salute");
            Console.WriteLine();

            int a = 5;
            int b = 10;

            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine();

            Console.WriteLine("a <= b and b > 0 ");
            Console.WriteLine(a <= b && b > 0);
            Console.WriteLine();

            Console.WriteLine("a > b and b > 0 ");
            Console.WriteLine(a > b && b > 0);
            Console.WriteLine();

            Console.WriteLine("a > b or b > 0 ");
            Console.WriteLine(a > b || b > 0);
            Console.WriteLine();

            Console.WriteLine("a > b or b < 0 ");
            Console.WriteLine(a > b || b < 0);
            Console.WriteLine();

            Console.WriteLine("a > b xor b < 0 ");
            Console.WriteLine(a > b ^ b < 0);
            Console.WriteLine();

            Console.WriteLine("a > b xor b > 0 ");
            Console.WriteLine(a > b ^ b > 0);
            Console.WriteLine();



            b ++;
            Console.WriteLine(b);
            int c = b/a;
            Console.WriteLine("b/a = {0}", c);
        }
    }
