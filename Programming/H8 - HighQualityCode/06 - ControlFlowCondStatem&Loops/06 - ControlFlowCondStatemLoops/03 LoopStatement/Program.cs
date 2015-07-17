using System;
using System.Collections.Generic;

namespace LoopStatement
{
    public class Program
    {
        public static void Main()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 15, 11 };

            if (Condition(array, 11))
            {
                Console.WriteLine("Value Found");
            }
        }

        private static bool Condition(int[] intArray, int expectedValue)
        {
            int len = intArray.Length;
            for (int i = 0; i < len; i++)
                if (i % 10 == 0 && intArray[i] == expectedValue)
                    return true;

            return false;                   
        }
    }
}

/*
 int i=0;
    for (i = 0; i < 100;) 
    {
       if (i % 10 == 0)
       {
        Console.WriteLine(array[i]);
        if ( array[i] == expectedValue ) 
        {
           i = 666;
        }
        i++;
       }
       else
       {
            Console.WriteLine(array[i]);
        i++;
       }
    }
    // More code here
    if (i == 666)
    {
        Console.WriteLine("Value Found");
    }
 */