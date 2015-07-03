/*Problem 1. Student class

Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, 
university, faculty. Use an enumeration for the specialties, universities and faculties.
Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentClass
{
    class Program
    {
        static void Main()
        {
            Student st1 = new Student("Pepo", "Galev", "Gadevski", "DM-011249-783314", "avn. Wall Street 1", "0866969123", "hot@mail.net", "Practical Mathematics", 
                Specialties.Mathematics, Faculties.MathematicsAndInformatics, Universities.SU);
            Student st2 = new Student("Pepo", "Galev", "Gadevski", "DM-011249-783314", "avn. Wall Street 1", "0866969123", "hot@mail.net", "Practical Mathematics",
                Specialties.Mathematics, Faculties.MathematicsAndInformatics, Universities.SU);
            Student st4 = new Student("PepoV", "Galev", "Gadevski", "DM-011249-783314", "avn. Wall Street 1", "0800000001", "hot@mail.net", "Practical Mathematics",
                Specialties.Mathematics, Faculties.MathematicsAndInformatics, Universities.TU);
            Student st5 = new Student("PepoV", "Galev", "Gadevski", "AM-011249-783314", "avn. Wall Street 1", "0800000001", "hot@mail.net", "Practical Mathematics",
                Specialties.Mathematics, Faculties.MathematicsAndInformatics, Universities.TU);

            

        }




    }
}


// My Tests
/*
Console.WriteLine(st1.ToString());
            Console.WriteLine(st1.GetHashCode());

            if (st1 == st2)
                Console.WriteLine("They Are ==");

            if (st1.Equals(st2))
                Console.WriteLine("Apear when choose 'Equals'");

            var st3 = st2.Clone();     // (Student)st2.Clone();
            var hashSet = new HashSet<object>();
            hashSet.Add(st1);
            hashSet.Add(st2);
            hashSet.Add(st3);
            // hashSet.Add(st4);
            if (hashSet.Count != 1)
                Console.WriteLine("They are with different Hash_Code");

            
            var hash1 = st1.GetHashCode();
            var hash2 = st2.GetHashCode();
            
            Console.WriteLine("hash1 {0} <> {1} hash2", hash1, hash2);
            
            Console.WriteLine(st1.CompareTo(st2));
            Console.WriteLine(222);
 */