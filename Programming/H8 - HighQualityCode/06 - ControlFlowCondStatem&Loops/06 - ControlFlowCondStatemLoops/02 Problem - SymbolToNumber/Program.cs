﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02SymbolToNumber
{
    class Program
    {
        static void Main()
        {
            int secret = int.Parse(Console.ReadLine());
            string expression = Console.ReadLine();
            int count = 0;
            int currentNumber;
            decimal result;

            foreach (char symbol in expression)
            {
                if (symbol == '@')
                {
                    break;
                }

                currentNumber = ValueOfCurrentSymbol(symbol, secret);

                // if possition is even
                if (count % 2 == 0)
                {
                    result = (decimal)currentNumber / 100.00M;
                    Console.WriteLine("{0:0.00}", result);
                }
                else
                {
                    result = (decimal)currentNumber * 100;
                    Console.WriteLine("{0}", result);
                }
                ++count;
            }
        }

        private static int ValueOfCurrentSymbol(char symbol, int secret)
        {
            int resultValue = Convert.ToInt32(symbol);
            if (Char.IsDigit(symbol))
            {
                resultValue = resultValue + secret + 500;
            }
            else if (Char.IsLetter(symbol))
            {
                resultValue = resultValue * secret + 1000;
            }
            else
            {
                resultValue = resultValue - secret;
            }

            return resultValue;
        }

    }
}


/*
 namespace Problem_2___Symbol_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int secret = int.Parse(Console.ReadLine());
            string expres = Console.ReadLine();
            int count = 0;
            int tempNum;
            char tempChar;
            decimal result;
            
            foreach (char symbol in expres)
            {
                tempNum = 0;
                if (symbol == '@')
                {
                    break;
                }
                tempNum = Convert.ToInt32(symbol);
                if (Char.IsDigit(symbol))   //digit,	add	to	its	char	code	SECRET and	add	500
                {
                    tempNum = tempNum + secret + 500;
                    //Console.WriteLine(tempNum);
                }
                else if (Char.IsLetter(symbol)) //letter, multiply its	char code by the given SECRET and add 1000
                {
                    tempNum = tempNum * secret + 1000;
                }
                else    //not	a	digit,	letter	or	“@” (any	other	symbol),subtract from its char  code	SECRET
                {
                    tempNum = tempNum - secret;
                    //Console.WriteLine("NO Digit");
                }

                //Console.WriteLine(tempNum);
                

                //check even or odd
                if (count % 2 == 0)   //is even
                {                           //divide the encoded value by 100 and round	the	precision to 2 digits after the	decimal	point
                    result = (decimal)tempNum / 100.00M;
                    Console.WriteLine("{0:0.00}", result);
                }
                else    //is odd
                {       //multiply its	encoded	value	by	100
                    result = (decimal)tempNum * 100;
                    Console.WriteLine("{0}", result);
                }

                ++count;
            }

            //char t = 'T';
            //char e = 'e';
            //
            //int num1 = Convert.ToInt32(t);
            //Console.WriteLine(num1);
            //Console.WriteLine(num1 + 1);
            //
            //int tempNum = int.Parse(t.ToString());
            //Console.WriteLine(tempNum);
        }
    }
}

 */