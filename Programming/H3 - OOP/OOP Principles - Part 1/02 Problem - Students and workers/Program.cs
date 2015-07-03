/*Problem 2. Students and workers

Define abstract class Human with a first name and a last name. Define a new class Student which is derived from Human and 
has a new field – grade. Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay and 
a method MoneyPerHour() that returns money earned per hour by the worker. Define the proper 
constructors and properties for this hierarchy.
Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
Initialize a list of 10 workers and sort them by money per hour in descending order.
Merge the lists and sort them by first name and last name.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemStudentsAndWorkers;

namespace ProblemStudentsAndWorkers
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Hristo", "Ivanov", 'A'),
                new Student("Todor", "Afrikanski", 'A'),
                new Student("Kamen", "Gorev", 'D'),
                new Student("Toshko", "Popov", 'B'),
                new Student("Nikodim", "Afrikanski", 'C'),
                new Student("Toshko", "Filipov", 'A'),
                new Student("Prodan", "Afrikanski", 'B'),
                new Student("Toshko", "Nemski", 'D'),
                new Student("Toshko", "Qponsi", 'A')
            };

            var orderedByGrade = students.OrderBy(x => x.Grade);

            foreach (var student in orderedByGrade)
            {
                Console.WriteLine("Name: " + student.FirstName + " " + student.LastName + ", Grade: " + student.Grade);
            }

            Console.WriteLine();

            List<Worker> workers = new List<Worker>
            {
                new Worker("Pesho", "Toshev", 200, 8),
                new Worker("Toshko", "Afrikanski", 245, 8),
                new Worker("Kamen", "Georgiev", 222, 8),
                new Worker("Toshko", "Popov", 245, 8),
                new Worker("Nikodim", "Afrikanski", 300, 8),
                new Worker("Toshko", "Filipov", 245, 8),
                new Worker("Prodan", "Afrikanski", 245, 8),
                new Worker("Toshko", "Nemski", 245, 8),
                new Worker("Toshko", "Qponsi", 245, 8),
                new Worker("Rafcho", "Afrikanski", 245, 8)
            };

            var orderedByEarning = workers.OrderByDescending(x => x.MoneyPerHour());

            foreach (var worker in orderedByEarning)
            {
                Console.WriteLine("Name: {0} {1}; Money per hour: {2:F2}", worker.FirstName, worker.LastName,
                    worker.MoneyPerHour());
            }

            Console.WriteLine("\nMerged and sorted by first and last name: ");
            var merged = students.Concat<Human>(workers).OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach (var person in merged)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }

        }
    }
}
