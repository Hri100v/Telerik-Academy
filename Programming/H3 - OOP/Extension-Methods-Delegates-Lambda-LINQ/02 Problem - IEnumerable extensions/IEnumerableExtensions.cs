using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMinMethod
{
    static class IEnumerableExtensions
    {
        public static T Apply<T>(this IEnumerable<T> collection,
            Func<T, T, T> applyFunc, T startValue)
        {
            var result = startValue;

            foreach (var item in collection)
            {
                result = applyFunc(result, item);
            }

            return result;
        }

        // average
        static decimal Average<T>(this IEnumerable<T> items) where T : IComparable<T>
        {
            dynamic average = null;
            decimal counter = 0;
            foreach (var i in items)
            {
                average += i;
                ++counter;
            }

            return average / counter;
        }
    }
}
