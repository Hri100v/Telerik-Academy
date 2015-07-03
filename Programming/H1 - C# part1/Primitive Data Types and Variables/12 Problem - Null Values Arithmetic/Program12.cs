/*
 * Problem 12. Null Values Arithmetic

    Create a program that assigns null values to an integer and to a double variable.
    Try to print these variables at the console.
    Try to add some number or the null literal to these variables and print the result.
 */

using System;

class integerDouble
{
    static void Main()
    {
        Console.WriteLine("Salute!");

        //integer
        Console.WriteLine("\"integer\"");
        Console.WriteLine("==================");
        int? nullInt = null;                    //with ? (question mark) transform to local variable
        Console.WriteLine(nullInt.HasValue);    //false
        //Console.WriteLine(nullInt.Value);     //give error
        Console.WriteLine(nullInt);             //give empty string
        nullInt = 1;
        Console.WriteLine(nullInt.HasValue);    //true
        Console.WriteLine(nullInt.Value);       //1
        Console.WriteLine(nullInt);             //1
        Console.WriteLine();

        //double
        Console.WriteLine("\"double\"");
        Console.WriteLine("==================");
        double? nullD = null;                   //double nullD = null;      in this case give error
        Console.WriteLine(nullD);               //empty
        Console.WriteLine(nullInt.Value);       //1
        Console.WriteLine(nullInt.HasValue);    //true
        nullD = 1.1230987654321;
        Console.WriteLine(nullD);               //1.1230987654321
        Console.WriteLine(nullInt.Value);       //1
        Console.WriteLine(nullInt.HasValue);    //true

    }
}
