/*Problem 5. Larger than neighbours

Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Problem___Larger_than_neighbours
{
    class IsLarger
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write array of integer.");
            Console.WriteLine("Write element one by one separate with 'Enter'. \nFor Quit enter something else of number.");
            string input;
            List<int> array = new List<int>();
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

            Console.WriteLine("Write index of number that compare.");
            int index = int.Parse(Console.ReadLine());
            if (index == 0 || index == array.Count - 1)
            {
                Console.WriteLine("That is boundery elemnt.");
            }
            else
            {
                Console.WriteLine("Element[{0}] = {1} is larger then neighbours -> {2}", index, array[index], IsLargerNeighbours(array, index));
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
