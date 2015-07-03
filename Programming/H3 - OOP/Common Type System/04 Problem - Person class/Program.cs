/*Problem 4. Person class

Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. 
Override ToString() to display the information of a person and if age is not specified – to say so.
Write a program to test this functionality.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPersonClass
{
    class Program
    {
        static void Main()
        {
            var p1 = new Person("Gosho", 19);
            var p2 = new Person("Gita", null);

            Console.WriteLine(p1 + Environment.NewLine + p2);

        }
    }
}
