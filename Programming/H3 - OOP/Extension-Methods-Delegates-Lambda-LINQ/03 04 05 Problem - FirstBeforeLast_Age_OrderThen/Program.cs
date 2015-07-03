/*Problem 3. First before last

Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
Use LINQ query operators.
 */

/*Problem 4. Age range

Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
 */

/*Problem 5. Order students

Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
Rewrite the same with LINQ.
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main()
        {
            var students = new[]
            {
                new {FirstName = "Ivan", LastName = "Ivanov", Age = 18},
                new {FirstName = "Pesho", LastName = "Ivanov", Age = 20},
                new {FirstName = "Elka", LastName = "Todorova", Age = 19},
                new {FirstName = "Pesho", LastName = "Velikov", Age = 24},
                new {FirstName = "Kamen", LastName = "Prodanov", Age = 26},
                new {FirstName = "Nikodim", LastName = "Nikiforov", Age = 25},
                new {FirstName = "Pesho", LastName = "Antonov", Age = 20},

            };
            Console.WriteLine("All Students!");
            Print(students);
            Console.WriteLine();

            //var resPr3 = students.Select(st => st.FirstName.CompareTo(st.LastName) < 0 ? st.LastName : st.FirstName).ToArray();
            //Print(resPr3);
            // Problem 3
            Print(students.Where(x => x.FirstName.CompareTo(x.LastName) < 0));

            // Problem 4
            Print(students.Where(st => st.Age > 18 && st.Age <= 24));

            // Problem 5
            Print(students.OrderBy(s => s.FirstName).ThenByDescending(st => st.LastName));

        }

        static void Print(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item + "\n");
            }
            Console.WriteLine(new string('=', 55));
        }
    }
}
