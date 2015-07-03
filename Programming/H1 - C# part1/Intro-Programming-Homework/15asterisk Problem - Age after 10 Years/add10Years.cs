/*
 * Problem 15.* Age after 10 Years
    Write a program to read your birthday from the console and print how old you are now and how old you will be
    after 10 years.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class add10Years
    {
        static void Main()
        {           
            Console.WriteLine("How much old are you?");
            
            string ageWrite;
            int ageVal;
            bool valBool = false;
            
            do
            {
                Console.WriteLine("(enter correct number)");
                Console.WriteLine();
                ageWrite = Console.ReadLine();
                if (int.TryParse(ageWrite, out ageVal))
                { 
                    Console.WriteLine("Your age is " + ageVal);
                    Console.WriteLine();
                    int age10 = ageVal + 10;
                    Console.WriteLine();
                    Console.WriteLine("After 10 years you will be {0} years old.", age10);
                    valBool = true;
                } else {
                    Console.WriteLine("Incorrect date");
                    valBool = false;
                    Console.WriteLine("Write correct information.");
                }
            } while(valBool != true);
        }
    }