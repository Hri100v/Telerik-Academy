using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Pesho";
            var id = 54321;
            var idLowBound = 10000;
            var idHighBound = 99999;

            var anotherStudent = new Student(name, id + 1);
            var student = new Student(name, id);
            var result = student.CompareTo(anotherStudent) < 0;
            Console.WriteLine(result);
            var course = new Course("HQC");
            Console.WriteLine(course);
        }
    }
}
