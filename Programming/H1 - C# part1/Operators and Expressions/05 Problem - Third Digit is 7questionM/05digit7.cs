/*Problem 5. Third Digit is 7?

Write an expression that checks for given integer if its third digit from right-to-left is 7.
Examples:

n	    Third digit 7?
5	    false
701	    true
9703	true
877	    false
777877	false
9999799	true
 */

using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter some number... ");
            int num = int.Parse(Console.ReadLine());
            int result1 = num / 100;
            Console.WriteLine();
            int result2 = result1 % 10;
            if (result2 == 7)
            {
                Console.WriteLine("Third digit is 7.");
            }
            else
            {
                Console.WriteLine("Third digit is something different from 7.");
            }
            
        }
    }