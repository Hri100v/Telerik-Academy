using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01ABC
{
    class Program
    {
        static void Main()
        {
            int a = ConsoleParseInt();
            int b = ConsoleParseInt();
            int c = ConsoleParseInt();

            ThreeNumberPresent(a, b, c);
        }

        private static int ConsoleParseInt()
        {
            return int.Parse(Console.ReadLine());
        }

        private static void ThreeNumberPresent(int a, int b, int c)
        {
            int[] array = new int[] { a, b, c };
            int smallest = SmallestNumer(array);
            int biggest = BiggestNumer(array);
            decimal arithmetic = ArithmeticNumer(array);

            Console.WriteLine(biggest);
            Console.WriteLine(smallest);
            Console.WriteLine("{0:F3}", arithmetic);
        }


        private static int SmallestNumer(int[] array)
        {
            int smallest = array[0];

            for (int i = 0; i < array.Length; i++)
                if (smallest > array[i])
                    smallest = array[i];
            
            return smallest;
        }

        private static int BiggestNumer(int[] array)
        {
            int biggest = array[0];

            for (int i = 0; i < array.Length; i++)
                if (biggest < array[i])
                    biggest = array[i];

            return biggest;
        }

        private static decimal ArithmeticNumer(int[] array)
        {
            decimal arithmetic = 0.0M;
            int length = array.Length;
            for (int i = 0; i < length; i++)
                arithmetic += array[i];

            arithmetic /= length;

            return arithmetic;
        }
    }
}


/*
 namespace Problem_1
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            decimal smallest;
            decimal biggest;
            decimal arithResult;

            if (a > b && a> c)
            {
                biggest = (decimal)a;
                if (b > c)
                {
                    smallest = (decimal)c;
                }
                else
                {
                    smallest = (decimal)b;
                }
            }
            else if (b > c && b > a)
            {
                biggest = (decimal)a;
                if (c < a)
                {
                    smallest = (decimal)c;
                }
                else
                {
                    smallest = (decimal)a;
                }
            }
            else
            {
                biggest = (decimal)c;
                if (b < a)
                {
                    smallest = (decimal)b;
                }
                else
                {
                    smallest = (decimal)a;
                }
            }

            arithResult = (a + b + c) / 3.00M;

            Console.WriteLine(biggest);
            Console.WriteLine(smallest);
            Console.WriteLine("{0:F3}", arithResult);

        }
    }
}
 */