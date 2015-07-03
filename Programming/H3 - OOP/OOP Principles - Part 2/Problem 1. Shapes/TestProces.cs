using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemShapesX
{
    class TestProces
    {
        public static void Test()
        {

        Shape[] sumFigures = new Shape[]
        {
            new Square(4),
            new Triangle(2.5, 3),
            new Rectangle(5.7, 8.9),
            new Square(2.123)
        };

            foreach (var fig in sumFigures)
            {
                Console.WriteLine(fig);
            }
            Console.WriteLine();

        }   // end Test()


    } // end classTestProces
}
