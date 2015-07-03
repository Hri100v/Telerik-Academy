/*Problem 2. IEnumerable extensions

Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMinMethod
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-', 15));
            // IEnumerableExtensions test1 = new IEnumerableExtensions(); << can`t applay instance.
            var test1 = new[] { 1, 2, 7, 5, 3 };
            var r = test1.Max();
            Console.WriteLine(r);

            // test SUM
            var result1 = test1.Apply(Sum, 0);
            Console.WriteLine(result1);
            //testing
            var result1b = test1.Apply(Sum, test1[0]);
            Console.WriteLine(result1b);

            // test PRODUCT
            var result2 = test1.Apply(Product, 1);
            Console.WriteLine(result2);

            // test MIN
            var result3 = test1.Apply(Min, test1[0]);
            Console.WriteLine(result3);

            // test MAX
            var result4 = test1.Apply(Max, test1[0]);
            Console.WriteLine(result4);

            // test AVERAGE
            Console.WriteLine(test1.Average());
            Console.WriteLine(test1.Apply(Count, 0));

        }


        // public delegate void SomeDelegate<T>(T item);

        // sum
        private static int Sum(int a, int b)
        {
            return a + b;
        }

        // product
        private static int Product(int a, int b)
        {
            return a * b;
        }

        // min
        private static int Min(int a, int b)
        {
            var result = a;
            var temp = b;
            if (result > temp)
                result = temp;
            return result;
        }

        // max
        private static int Max(int arg1, int arg2)
        {
            return arg1 > arg2 ? arg1 : arg2;
        }

        // count
        private static int Count(int a, int b)
        {
            var result = a + 1;
            return result;
        }


    }


}
