using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintStatistics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] testArray = {1.3, 5.5, 12.0, 0, 6.1, 89.9};
            PrintStatistics(testArray, 3);
        }

        public static void PrintStatistics(double[] arrayOfMembers, int count)
        {
            double max = arrayOfMembers[0];
            for (int i = 0; i < count; i++)
            {
                if (arrayOfMembers[i] > max)
                {
                    max = arrayOfMembers[i];
                }
            }

            Console.WriteLine("Max: ");
            Print(max);

            double min = arrayOfMembers[0];
            for (int i = 0; i < count; i++)
            {
                if (arrayOfMembers[i] < max)
                {
                    max = arrayOfMembers[i];
                }
            }

            Console.WriteLine("Min: ");
            Print(max);

            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += arrayOfMembers[i];
            }

            double average = sum / count;
            Console.WriteLine("Average: ");
            Print(average);
        }

        public static void Print(double exposedValue)
        {
            Console.WriteLine(exposedValue);
            Console.WriteLine();
        }
    }
}
