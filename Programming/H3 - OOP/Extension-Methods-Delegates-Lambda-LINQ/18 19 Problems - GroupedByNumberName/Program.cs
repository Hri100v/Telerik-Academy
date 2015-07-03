/*
Problem 18. Grouped by GroupNumber

Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
Use LINQ.
 * 
Problem 19. Grouped by GroupName extensions

Rewrite the previous using extension methods.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace _18_19_Problems___GroupedByNumberName
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupStudents = new[] 
            {
                new {FirstName = "Bonn", LastName = "Jonie", GroupNumber = 2},
                new {FirstName = "Deon", LastName = "Jeff", GroupNumber = 1},
                new {FirstName = "Ton", LastName = "Adams", GroupNumber = 3},
                new {FirstName = "Dion", LastName = "Tom", GroupNumber = 2},
                new {FirstName = "Bonn", LastName = "Rams", GroupNumber = 3},
                new {FirstName = "Don", LastName = "Maison", GroupNumber = 2},
            };
            Print(groupStudents);

            Console.WriteLine(new string('^', 35));

            var groupRes1 =
                from st in groupStudents
                group st.LastName by st.GroupNumber into grp
                select new { GroupNumber = grp.Key, LastName = grp.ToList() };
            Print(groupRes1);

            Console.WriteLine(new string('1', 35));


            var students = new List<Person>()
            {
                new Person ("Jonie", 2),
                new Person ("Jeff", 1),
                new Person ("Adams", 3),
                new Person ("Tom", 2),
                new Person ("Rams", 3),
                new Person ("Maison", 2),
                
            };
            var groupRes2 =
                students.GroupBy(p => p.GroupNumber, p => p.LastName,
                         (key, g) => new { GroupNumber = key, LastName = g.ToList() });
            Print(groupRes2);
            Console.WriteLine(new string('2', 35));

            // Console.WriteLine(string.Join(" ! ", groupRes2.Select(x => x.GetHashCode())));

            var groupRes3 =
                from st in students
                orderby st.GroupNumber
                select st;
            Print(groupRes3);

            Console.WriteLine(new string('3', 35));

            var order = students.OrderBy(st => st.LastName);
            Print(order);

            Console.WriteLine();
            Console.WriteLine();
            // annother test
            List<Person> personSt = new List<Person>();
            Person stud1 = new Person("Ivanov", 2);
            Person stud2 = new Person("Ivanova", 2);
            Person stud3 = new Person("Hristov", 3);
            Person stud4 = new Person("Todorova", 1);
            Person stud5 = new Person("MIvanova", 1);
            Person stud6 = new Person("Bogdanov", 2);
            personSt.Add(stud1);
            personSt.Add(stud2);
            personSt.Add(stud3);
            personSt.Add(stud4);
            personSt.Add(stud5);
            personSt.Add(stud6);
            Print(personSt);
            foreach (var item in personSt)
            {
                Console.WriteLine(item.LastName + " " + item.GroupNumber);
            }




        }

        private static void Print(IEnumerable<Person> strArray)
        {
            foreach (var item in strArray)
            {
                Console.WriteLine("{0} from [{1}] group.", item.LastName, item.GroupNumber);
            }
        }

        internal class Person
        {
            string firstName;
            string lastName;
            int groupNumber;

            public Person(string lastName, int groupNumber)
            {
                this.LastName = lastName;
                this.GroupNumber = groupNumber;
            }

            public Person(string firstName, string lastName, int groupNumber)
                : this(lastName, groupNumber)
            {
                this.FirstName = firstName;
            }


            public string FirstName
            {
                get { return this.firstName; }
                set { this.firstName = value; }
            }

            public string LastName
            {
                get { return this.lastName; }
                set { this.lastName = value; }
            }

            public int GroupNumber
            {
                get { return this.groupNumber; }
                set { this.groupNumber = value; }
            }
        }
    }
}
