using System;
using System.Text;
using System.Collections.Generic;


namespace ProblemSchool
{

    public class School
    {
        /// must have different classess and 
        /// each class have diff > desciplines
        public static void SchoolRepresent()
        {
#region students
            var st1 = new Student("Petko", "Penkov", 20, "123456");
            var st2 = new Student("Nataliya", "Simeonova", 22, "123693", "she is very hot");
            var st3 = new Student("Ben", "Ten", 23, "123875", "is one crazy guy");
            var st4 = new Student("Zoe", "Saldana", 36, "911269", "isHot ? HOT : avatar");
            

#endregion
        
#region definde disciplines
            // [define different desciplines]
            // algebra, geometry, solid geometry, fitness, football, fencing, 
            // human body, biology, botany, physics, astronomy, natural science, 
            // geography, economics, history, art history, painting, modeling, philosophy
            Discipline algebra = new Discipline("Algebra", 14, 42);
            Discipline geometry = new Discipline("Geometry", 14, 32);
            Discipline solidGeom = new Discipline("Solid geometry", 10, 28);
            Discipline fitness = new Discipline("Fitness", 1, 27);
            Discipline football = new Discipline("Football", 1, 27);
            Discipline fencing = new Discipline("Fencing", 1, 27);
            Discipline humanBody = new Discipline("Human body", 21, 7);
            Discipline biology = new Discipline("Biology", 14, 14);
            Discipline botany = new Discipline("Botany", 14, 14);
            Discipline physics = new Discipline("Physics", 21, 14);
            Discipline astronomy = new Discipline("Astronomy", 14, 14);
            Discipline naturalScience = new Discipline("Natural science", 16, 14);
            Discipline geography = new Discipline("Geography", 26, 4);
            Discipline economics = new Discipline("Economics", 18, 12);
            Discipline history = new Discipline("History", 22, 8);
            Discipline artHistory = new Discipline("Art history", 24, 6);
            Discipline painting = new Discipline("Painting", 10, 20);
            Discipline modeling = new Discipline("Modeling", 10, 20);
            Discipline philosophy = new Discipline("Phylosophy", 25, 5);
#endregion

#region teachers with disciplines
            List<Discipline> math = new List<Discipline>() { algebra, geometry, solidGeom };
            Teacher gProdanov = new Teacher("Stamat", "Prodanov", 54, math);
            //Console.WriteLine(gProdanov.ToString());

            List<Discipline> PT = new List<Discipline>() { fitness, football, fencing };
            List<Discipline> bio = new List<Discipline>() { humanBody, biology, botany };
            List<Discipline> phys = new List<Discipline>() { physics, astronomy };
            List<Discipline> natureS = new List<Discipline>() { naturalScience, };
            List<Discipline> geo = new List<Discipline>() { geography, economics };
            List<Discipline> hist = new List<Discipline>() { history, artHistory };
            List<Discipline> art = new List<Discipline>() { painting, modeling };
            List<Discipline> phil = new List<Discipline>() { philosophy };
            
            Teacher gSkubarev = new Teacher("Darin", "Skubarev", 48, PT);
            Teacher gjDankova = new Teacher("Penka", "Dankova", 59, phys);
            Teacher gYordanov = new Teacher("Boris", "Yordanov", 55, natureS);
            //...
#endregion  

            var stdnts = new List<Student>() { st1, st2, st3, st4};
            var tchrs = new List<Teacher>() { gProdanov, gSkubarev };
            SchoolClass artClass = new SchoolClass("Art and Craft", tchrs, stdnts);
            //var repr = new StringBuilder();
            //repr.AppendLine(artClass.ToString());

            Console.WriteLine(artClass.ToString());

        }
    }
}
