/*
 * Problem 16.* Print Long Sequence
    Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
    You might need to learn how to use loops in C# (search in Internet).
 */

using System;

    class LongSequence
    {
        static void Main()
        {
            Console.WriteLine("Hello dear.");
            Console.WriteLine();

            //int i = 2;
            for(int i = 2; i <= 1000; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(-i);
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
