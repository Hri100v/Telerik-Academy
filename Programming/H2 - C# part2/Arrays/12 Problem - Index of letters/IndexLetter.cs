/*Problem 12. Index of letters

Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array.
 */

using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

class IndexLetter
{
    static void Main()
    {
        int alphSize = 26;      //alphSize * 2
        List<char> arrayAlph = new List<char>();
        int lowerStart = 97;    //122 end
        int upperStart = 65;    //90  end
        //int index = 0;
        for (int i = lowerStart, k = upperStart; i < alphSize+ lowerStart; i++)
        {
            arrayAlph.Add(Convert.ToChar(i));
            arrayAlph.Add(Convert.ToChar(k));
            //Console.Write(Convert.ToChar(i));
            //Console.WriteLine(Convert.ToChar(k));
            ++k;
            //++index;
        }
        //Console.WriteLine(arrayAlph[0]);
        Console.WriteLine();
        //foreach (var item in arrayAlph)
        //{
        //    Console.WriteLine(item);
        //}

        Console.WriteLine("Write some word.");
        string word = Console.ReadLine();
        int sizeWord = word.Length;
        char[] arrWord = new char[sizeWord];
        for (int i = 0; i < sizeWord; i++)
        {
            arrWord[i] = word[i];
        }
        Console.WriteLine();
        for (int i = 0; i < arrayAlph.Count; i++)
        {
            Console.Write(" {0}", arrayAlph[i]);
            int g = 0;
            do
            {
                if (arrayAlph[i] == arrWord[g])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("  {0}({1})  ", arrWord[g], i);
                    Console.Beep(1767, 300);
                    Thread.Sleep(100);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                ++g;
            } while (g < sizeWord);
            
            Thread.Sleep(100);
        }

        Console.WriteLine(); Console.WriteLine();

        //some sounds :)
        //Console.Beep(5000, 300);
        //Thread.Sleep(100);
        //Console.Beep(1200, 300);
        //Thread.Sleep(100);
        //Console.Beep(37, 300);
        //Thread.Sleep(100);
        //Console.Beep(1767, 300);
    }
}