/*
 * Problem 7. Quotes in Strings

    Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
    Do the above in two different ways - with and without using quoted strings.
    Print the variables to ensure that their value was correctly defined.
 */

using System;

    class explicitString
    {
        static void Main()
        {
            Console.WriteLine("Salute");
            Console.WriteLine();

            string str1 = "The \"use\" of quotations causes difficulties";
            Console.WriteLine(str1);

            string str2 = @"The ""use"" of quotations causes difficulties";
            Console.WriteLine(str2);

            char quotedStr = '\u0022';
            string str3 = @"The {0}use{0} of quotations causes difficulties";
            Console.WriteLine(str3, quotedStr);
        }
    }
