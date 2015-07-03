/*Problem 11. Random Numbers in Given Range

Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
Examples:

n	min	max	random numbers
5	0	1	1 0 0 1 1
10	10	15	12 14 12 15 10 12 14 13 13 11
Note: The above output is just an example. Due to randomness, your program most probably will produce different results.
 */

using System;

class RandomNGivenRange
{
    static void Main()
    {
        Console.WriteLine("Prints N random numbers in the range [min...max].");
        Random randN = new Random();
        int n, min, max;
        Console.WriteLine("Please enter correct integer N > 1.");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
        {
            Console.WriteLine("Not correct. Please enter correct integer N > 0.");
        }

        Console.WriteLine("Please enter min.");
        while (!int.TryParse(Console.ReadLine(), out min))
        {
            Console.WriteLine("Please enter a correct 'min' value.");
        }
        
        
        Console.WriteLine("Please enter max.");
        while (!int.TryParse(Console.ReadLine(), out max) || max == min)
        {
            Console.WriteLine("Please enter a correct 'max' value.");
        }

        Console.Write("{0} random numbers in interval [{1}...{2}]: ", n, min, max);
        for (int i = 0; i < n; i++)
        {
            Console.Write(randN.Next(min, max));
            Console.Write(" ");
        }
        Console.WriteLine();
        //Console.WriteLine(randN.Next(5, 10));
    }
}