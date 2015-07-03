/*
Problem 20.* Infinite convergent series

By using delegates develop an universal static method to calculate the sum of infinite convergent series with given precision depending on a function of its term. By using proper functions for the term calculate with a 2-digit precision the sum of the infinite series:

1 + 1/2 + 1/4 + 1/8 + 1/16 + …
1 + 1/2! + 1/3! + 1/4! + 1/5! + …
1 + 1/2 - 1/4 + 1/8 - 1/16 + …
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20asteriks_Problem___Infinite_convergent_series
{
    class Program
    {
        static void Main()
        {
            Student[] students = GenerateStudentArray();

			// Solution with LINQ query
			Console.WriteLine(new string('=', 70));
			Console.WriteLine("Linq : ");
			Console.WriteLine(new string('=', 70));

			var orderedStudents = from st in students
									  orderby st.GroupName
									  select st;

			foreach (var student in orderedStudents)
			{
				Console.WriteLine(student);
			}

			// Solution with extension methods
			Console.WriteLine(new string('=', 70));
			Console.WriteLine("Extension Methods : ");
			Console.WriteLine(new string('=', 70));

			orderedStudents = students.OrderBy(st => st.GroupName);

			foreach (var student in orderedStudents)
			{
				Console.WriteLine(student);
			}

			Console.WriteLine(new string('=', 70));
		}

		public static Student[] GenerateStudentArray()
		{
			string[] names = { "Ivan", "Ivanka", "Maria", "Gosho", "Bai Kostadin", "Radi", "Mitko", "Joro" };

			string[] groups = { "Maths", "Biology", "Law", "ComputerScience", "RoketScience" };

			Random rnd = new Random();

			Student[] students = new Student[rnd.Next(20, 31)];

			for (int i = 0; i < students.Length; i++)
			{
				students[i] = new Student(names[rnd.Next(0, names.Length)], groups[rnd.Next(0, groups.Length)]);
			}

			return students;
		}
        
        public class Student
    {
        private string name;
        private string groupName;

        public Student(string StudentName, string StudentGroupName)
        {
            this.Name = StudentName;
            this.GroupName = StudentGroupName;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public string GroupName
        {
            get { return this.groupName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }

                this.groupName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} is in group {1}", this.Name, this.GroupName);
        }
    }
    }
}