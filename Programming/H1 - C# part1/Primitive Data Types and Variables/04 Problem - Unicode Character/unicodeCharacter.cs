/*
 * Problem 4. Unicode Character

    Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax,
    and then print it.
    Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be *.
 */

using System;

    class unicodeCharacter
    {
        static void Main()
        {
            Console.WriteLine("Hello.");
            Console.WriteLine();

            Console.WriteLine("How to represent 'asteriks' symbol (*) with decimal unicode (ASCII table).");
            
            String uDecToHex = Convert.ToString(Convert.ToInt32("42", 10), 16);
            //Console.WriteLine(uDecToHex + " this is on hex"); only for find hex value
            //char i = '\u00' + Convert.ToString(uDecToHex);
          /*string a = "\\u00";
            string b = "2A";
            string c = a + b;
            char d = Convert.ToChar(c);
            Console.WriteLine(d);*/

            char asteriks = '\u002A';
            //string asteriks = String.Format("{0:X}", uDecToHex);
            Console.WriteLine("THE symbol is {0}", asteriks);
        }
    }
