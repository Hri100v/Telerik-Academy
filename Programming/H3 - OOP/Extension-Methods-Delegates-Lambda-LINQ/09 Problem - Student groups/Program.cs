/*Problem 9. Student groups

Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
Create a List<Student> with sample students. Select only the students that are from group number 2.
Use LINQ query. Order the students by FirstName.
 */

/*Problem 10. Student groups extensions

Implement the previous using the same query expressed with extension methods.
 */

/*Problem 11. Extract students by email

Extract all students that have email in abv.bg.
Use string methods and LINQ.
 */

/*Problem 12. Extract students by phone

Extract all students with phones in Sofia.
Use LINQ.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Problem___Student_groups
{
    class Program
    {
        public const string domain = "abv.bg";
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>() 
            {
                new Student("Nataly", "Hristova", 8222, 029669, "hot@mail.com", new List<int>{2, 3, 3, 5, 6}, 2),
                new Student("Hristo", "Hristov", 8215, 0886996321, "hot@mail.com", new List<int>{4, 5, 4, 5, 5}, 2),
                new Student("Pesho", "Hristov", 9123, 0896008711, "hot@abv.bg", new List<int>{6, 6, 4, 5, 5}, 3),
                new Student("Ivan", "Hristov", 7667, 0856900021, "hot@abv.bg", new List<int>{6, 6, 5, 6, 6}, 1),
                new Student("Minka", "Silvestar", 1696, 0280690069, "hot@abv.bg", new List<int>{6, 6, 6, 6, 6}, 2),
            };

            var selectionArr = students.FindAll(st => st.GroupNumber == 2).OrderByDescending(x => x.FirstName); ///.OrderBy(st => st.FirstName
            Print(selectionArr);

            var abv = students.Where(x => x.Email.Contains(domain)).ToArray();
            Print(abv);

            var tel = students.Where(x => x.Tel.ToString().StartsWith("02")).ToArray();
            Print(tel);
            
        }


        static void Print(IEnumerable<Student> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine("Student: {0} {1}, FN: {2}, Group Number: {3}, E-mail: {4}, tel: {5}", 
                    item.FirstName, item.LastName, item.FN, item.GroupNumber, item.Email, item.Tel);
                Console.WriteLine();
            }
            Console.WriteLine(new string('-', 55));
        }
    }
}
