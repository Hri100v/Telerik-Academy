using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
//using Extension_Methods;

namespace _01_Problem___StringBuilder.Substring
{
    public class ExtensionMethods
    {
        public static void Main()
        {
            StringBuilder test = new StringBuilder();
            test.Append("[");
            test.Append("test");
            test.Append("]");
            Console.WriteLine(test);
            //var testCut = new StringBuilder(test.ToString().Substring(1, 4));
            var testCut = test.Substring(1, 4);
            Console.WriteLine(testCut);

        }
    }
}






//var t1 = test.MaxCapacity;
//int[] test2 = new int[] { 1, 2, 3, 5, 7 };
//Console.WriteLine(string.Join(" | ", test2));
//var t2 = test2.Clone();
//Console.WriteLine(string.Join(" | ", (int[])t2));


///// h pr2
//// TestOv[] test3 = new TestOv[] { 1, 2, 3, 5, 7 };
//// TestOv mem1 = new TestOv(1);
//// TestOv mem2 = new TestOv();
//// mem2.MyProperty = 3;
//// Console.WriteLine(mem2.MyProperty);




//List<int> proba3 = new List<int>() { 1, 2, 3, 5, 7 };
//var cap = proba3.Capacity;
//Console.WriteLine("Capacity - {0}", cap);

////var min = Array
