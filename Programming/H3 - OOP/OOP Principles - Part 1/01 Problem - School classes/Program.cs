/*Problem 1. School classes

 * We are given a school. In the school there are classes of students. Each class has a set of teachers. 
Each teacher teaches, a set of disciplines. Students have a name and unique class number. 
Classes have unique text identifier. Teachers have a name. Disciplines have a name, number of lectures and number of exercises. 
Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).

 * Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, 
define the class hierarchy and create a class diagram with Visual Studio.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            School.SchoolRepresent();
//            //Shcool FirstSchool = new Shcool();
//            //new SchoolClass();
//            //// new Person();
//            //new Discipline();
//            // new Teacher();
//            // new Student();

//            var st1 = new Student("Petko", "Penkov", 20, "123456");
//            var p = new Person("Nabora", "Gorov", 31);

//            Console.WriteLine(p.ToString()); Console.WriteLine();
//            Console.WriteLine(st1.ToString());

//            var st2 = new Student("Nataliya", "Simeonova", 22, "123693", "she is very hot");
//            Console.WriteLine(st2.ToString());

//            //GetDisciplines();

//#region definde disciplines
//            // [define different desciplines]
//            // algebra, geometry, solid geometry, fitness, football, fencing, 
//            // human body, biology, botany, physics, astronomy, natural science, 
//            // geography, economics, history, art history, painting, modeling, philosophy
//            var algebra = new Discipline("Algebra", 14, 42);
//            var geometry = new Discipline("Geometry", 14, 32);
//            Discipline solidGeom = new Discipline("Solid geometry", 10, 28);
//            var fitness = new Discipline("Fitness", 1, 27);
//            var football = new Discipline("Football", 1, 27);
//            var fencing = new Discipline("Fencing", 1, 27);
//            var humanBody = new Discipline("Human body", 21, 7);
//            var biology = new Discipline("Biology", 14, 14);
//            var botany = new Discipline("Botany", 14, 14);
//            var physics = new Discipline("Physics", 21, 14);
//            var astronomy = new Discipline("Astronomy", 14, 14);
//            var naturalScience = new Discipline("Natural science", 16, 14);
//            var geography = new Discipline("Geography", 26, 4);
//            var economics = new Discipline("Economics", 18, 12);
//            var history = new Discipline("History", 22, 8);
//            var artHistory = new Discipline("Art history", 24, 6);
//            var painting = new Discipline("Painting", 10, 20);
//            var modeling = new Discipline("Modeling", 10, 20);
//            var philosophy = new Discipline("Phylosophy", 25, 5);
//#endregion

//            var math = new List<Discipline>() { algebra, geometry, solidGeom };
//            Teacher gProdanov = new Teacher("Stamat", "Prodanov", 54, math);
//            Console.WriteLine(gProdanov.ToString());

//            var PT = new List<Discipline>() { fitness, football, fencing };
//            var bio = new List<Discipline>() { humanBody, biology, botany };
//            var phys = new List<Discipline>() { physics, astronomy };
//            var natureS = new List<Discipline>() { naturalScience, };
//            var geo = new List<Discipline>() { geography, economics };
//            var hist = new List<Discipline>() { history, artHistory };
//            var art = new List<Discipline>() { painting, modeling };
//            var phil = new List<Discipline>() { philosophy };

//            var gSkubarev = new Teacher("Darin", "Skubarev", 48, PT);
//            var gjDankova = new Teacher("Penka", "Dankova", 59, phys);
//            var gYordanov = new Teacher("Boris", "Yordanov", 55, natureS);
//            //...
//            SchoolClass artClass = new SchoolClass();



        }

        /*
        public static void GetDisciplines()
        {
            // [define different desciplines]
            // algebra, geometry, solid geometry, fitness, football, fencing, 
            // human body, biology, botany, physics, astronomy, natural science, 
            // geography, economics, history, art history, painting, modeling, philosophy
            var algebra = new Discipline("Algebra", 14, 42);
            var geometry = new Discipline("Geometry", 14, 32);
            Discipline solidGeom = new Discipline("Solid geometry", 10, 28);
            var fitness = new Discipline("Fitness", 1, 27);
            var football = new Discipline("Football", 1, 27);
            var fencing = new Discipline("Fencing", 1, 27);
            var humanBody = new Discipline("Human body", 21, 7);
            var biology = new Discipline("Biology", 14, 14);
            var botany = new Discipline("Botany", 14, 14);
            var physics = new Discipline("Physics", 21, 14);
            var astronomy = new Discipline("Astronomy", 14, 14);
            var naturalScience = new Discipline("Natural science", 16, 14);
            var geography = new Discipline("Geography", 26, 4);
            var economics = new Discipline("Economics", 18, 12);
            var history = new Discipline("History", 22, 8);
            var artHistory = new Discipline("Art history", 24, 6);
            var painting = new Discipline("Painting", 10, 20);
            var modeling = new Discipline("Modeling", 10, 20);
            var philosophy = new Discipline("Phylosophy", 25, 5);
        }
         */
    }
}
