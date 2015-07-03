/*
 * Problem 6. Print Numbers
    Write a program to print the numbers 1, 101 and 1001, each at a separate line.
    Name the program correctly.
    You should submit in your homework the Visual Studio project holding the source code of the PrintNumbers program.
 */

using System;

class PrintNumbers
{
    static void Main()
    {
        //variation 1
        Console.WriteLine("variation 1");
        Console.WriteLine("1");
        Console.WriteLine("101");
        Console.WriteLine("1001");

        Console.WriteLine("\n");
        //variation 2
        Console.WriteLine("variation 2");
        Console.WriteLine("\n 1 \n 101 \n 1001");

        Console.WriteLine("\n");
        //variation 3
        Console.WriteLine("variation 3");
        int countLoop = 3 * 3;
        int i;

        for (i = 1; i <= countLoop; i += 4)
        {
            //1, 5, 9 -> 1, 101, 1001
            Console.WriteLine(Convert.ToString(i, 2));
        }
    }
}


