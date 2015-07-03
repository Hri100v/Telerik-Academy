/*
 * Problem 8. Isosceles Triangle

    Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
       ©

      © ©

     ©   ©

    © © © ©
    Note: The © symbol may be displayed incorrectly at the console so you may need to change the console 
    character encoding to UTF-8 and assign a Unicode-friendly font in the console.

    Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort 
    you put to fix it.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Salute©");
            Console.WriteLine();

            char charC = '\u00A9';
            string c = Convert.ToString(charC);
            Console.WriteLine(c + c + c + c + c + c + c + c + c + c + c + c + c + c + c + c + c + c + c + c + c + c + c + c + c);
            Console.WriteLine();
            Console.WriteLine();

            //char abc = System.Console.Write('\u00A9');            //test  
            Console.OutputEncoding = System.Text.Encoding.UTF8;     //for different OS
            Console.OutputEncoding = Encoding.UTF8;                 //not good. print with other symbols


            Console.WriteLine("   ©   ");
            Console.WriteLine();
            Console.WriteLine("  © ©  ");
            Console.WriteLine();
            Console.WriteLine(" ©   © ");
            Console.WriteLine();
            Console.WriteLine("© © © ©");
            Console.WriteLine();
        }
    }
