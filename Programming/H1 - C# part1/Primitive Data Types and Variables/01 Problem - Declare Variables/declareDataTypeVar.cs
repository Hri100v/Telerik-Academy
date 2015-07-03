/*
 * Problem 1. Declare Variables

    Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, 
    short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
    Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
    Submit the source code of your Visual Studio project as part of your homework submission.
 */

using System;

    class dataTypeVar
    {
        static void Main()
        {
            //I look to use less bits
            // # first variable = var1 = 52130 / var2 = -115 / var3 = 4825932 / var4 = 97 / var5 = -10000

            ushort var1 = 52130;
            sbyte var2 = -115;
            int var3 = 4825932;
            byte var4 = 97;
            short var5 = -10000;

            Console.WriteLine("var1:{0} ushort, var2:{1} sbyte, var3:{2} int, var4:{3} byte, var5:{4} short", var1, var2, var3, var4, var5);

        }
    }
