/*
 * Problem 2. Float or Double?
    Which of the following values can be assigned to a variable of type float and which to a variable of 
    type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
    Write a program to assign the numbers in variables and print them to ensure no precision is lost.
 */

using System;

    class choiceFloatDouble
    {
        static void Main()
        {
            float fl1 = 12.345F;
            float fl2 = 3456.091F;
            double d1 = 34.567839023;
            double d2 = 8923.1234857;
            Console.WriteLine("Type with different precision {0} is double/ {1} is float/ {2} is double/ {3} is float", d1, fl1, d2, fl2);
        }
    }
