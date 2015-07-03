/*Problem 5. Generic class

Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString().
Check all input parameters to avoid accessing elements at invalid positions.
 */
using System;

class Program
{
    static void Main()
    {
        GenericList<int> list = new GenericList<int>();

        {
            Console.WriteLine("# Auto grow/shrink");

            for (int i = 0; i < 10000; i++)
            {
                list.Add(i);

                Console.WriteLine("Count: {0}, Capacity: {1}", list.Count, list.Capacity);
            }

            while (list.Count > 16)
            {
                list.Remove(list.Count - 1);

                Console.WriteLine("Count: {0}, Capacity: {1}", list.Count, list.Capacity);
            }

            Console.WriteLine();
        }

        {
            Console.WriteLine("# List is");

            Console.WriteLine(list);

            Console.WriteLine();
        }

        {
            Console.WriteLine("# Min: {0}", list.Min());
            Console.WriteLine("# Max: {0}", list.Max());

            Console.WriteLine();
        }

        {
            Console.WriteLine("# Indexer");

            Console.WriteLine(list[2]);

            Console.WriteLine();
        }

        {
            Console.WriteLine("# Remove element");

            list.Remove(3);

            Console.WriteLine(list);

            Console.WriteLine();
        }

        {
            Console.WriteLine("# Add element");

            list.Insert(0, 10);
            list.Insert(3, 5);
            list.Insert(list.Count, 11);

            Console.WriteLine(list);

            Console.WriteLine();
        }

        {
            Console.WriteLine("# Index of");

            Console.WriteLine(list.IndexOf(4));

            Console.WriteLine();
        }

        {
            Console.WriteLine("# Clear");

            list.Clear();

            Console.WriteLine(list);
        }
    }
}