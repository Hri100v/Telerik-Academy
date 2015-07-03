/*Problem 1. Say Hello

Write a method that asks the user for his name and prints “Hello, <name>”
Write a program to test this method.
Example:

input	output
Peter	Hello, Peter!
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Problem___Say_Hello
{
    class Salute
    {
        static void Main()
        {
            Console.WriteLine("Try to write your name.");
            string input = Console.ReadLine();
            Console.WriteLine(SaluteName(input));
            PrintName();
        }
        static string SaluteName(string name) 
        {
            //Console.WriteLine("Hello, " + name + "!");
            name = "Hello " + name + "!";
            return name;
        }

        static void PrintName()
        {
            
            Console.WriteLine("Your last name.");
            string input = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Salute, Mr/ss {0}!", input);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
