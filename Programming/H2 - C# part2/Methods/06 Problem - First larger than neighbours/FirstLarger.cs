/*Problem 6. First larger than neighbours

Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
Use the method from the previous exercise.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csTut = _05_Problem___Larger_than_neighbours;
using _05_Problem___Larger_than_neighbours;

namespace TheFirstLargerElement
{
    class FirstLarger
    {
        static void Main()
        {
            List<int> array = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 55, 15, 5, 13, 2, 3, 7, 5 };
            /*List<int> array = new List<int>();
            while (true)
            {
                input = Console.ReadLine();
                int num;
                if (int.TryParse(input, out num))
                {
                    array.Add(num);
                }
                else
                {
                    break;
                }
            }
             */
            int length = array.Count;
            for (int index = 0; index < length; index++)
            {
                Console.WriteLine("This element[{0}] = {1} is larger or not -> {2}",index, array[index], FirstToLast(index, array));
            }
            Console.WriteLine("(or is a boundery [-1])");
            //Console.WriteLine("First element in array that is larger than its neighbours.");
            
        }
        public static string FirstToLast(int index, List<int> someArray)
        {
            if (index == 0 || index == someArray.Count - 1)
            {
                return "-1";
            }
            else
            {
                string falseOrTrue;
                falseOrTrue = IsLargerNeighbours(someArray, index).ToString();
                return falseOrTrue;
            }
        }

        public static bool IsLargerNeighbours(List<int> someArray, int index)
        {
            bool largerOrNot = false;

            if (someArray[index] > someArray[index + 1] && someArray[index] > someArray[index - 1])
            {
                largerOrNot = true;
            }
            return largerOrNot;
        }
    }
}
