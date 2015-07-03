/*
 * Problem 7. Print First and Last Name
    Create console application that prints your first and last name, each at a separate line.
 */
using System;


    class PrintFirstLastName
    {
        static void Main()
        {
            string nameFirst = "Icko";
            string nameLast = "Ickov";

            Console.WriteLine("First name: {1}, \nLast name: {0}", nameLast, nameFirst);
        }
    }