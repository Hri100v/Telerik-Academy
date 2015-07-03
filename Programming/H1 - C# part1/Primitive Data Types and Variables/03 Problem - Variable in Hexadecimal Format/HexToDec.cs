/*
 * Problem 3. Variable in Hexadecimal Format

    Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
    Use Windows Calculator to find its hexadecimal representation.
    Print the variable and ensure that the result is 254.
*/

using System;

    class convertingHexToDec

    {
        static void Main()
        {
            Console.WriteLine("Hello.");
            Console.WriteLine();

            String number = "254";
            Console.WriteLine();
            Console.Write("number '{0}' is hexadecimal after converting to decimal is ", number);
            int fromBase = 10;
            int toBase = 16;
            String result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
            Console.WriteLine("'{0}'", result);
            Console.WriteLine("{0}", 0xFe);
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
        }
    }