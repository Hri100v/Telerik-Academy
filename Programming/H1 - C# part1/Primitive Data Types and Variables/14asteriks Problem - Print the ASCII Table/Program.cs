using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Text.Encoder;

namespace _14asteriks_Problem___Print_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 0; i < 256; i++)
            {
                //string str = Convert.ToString(i, 8);
                Console.WriteLine("Number {0} have {1} ASCII", i, (char)i);
            }
            Console.WriteLine();
        }
    }
}
