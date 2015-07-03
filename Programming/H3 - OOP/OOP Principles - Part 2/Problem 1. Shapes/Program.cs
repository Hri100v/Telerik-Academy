/*
    Problem 1. Shapes

Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure 
 - (height * width for rectangle and 
 - height * width/2 for triangle).
Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) stored in an array.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProblemShapesX
{
    class Program
    {
        static void Main()
        {
            //var tr1 = new Triangle(13, 2.5);
            //Console.WriteLine(tr1.CalculateSurface());
            //Console.WriteLine(tr1);
            //var rect1 = new Rectangle(14.5, 3);
            //Console.WriteLine(rect1.CalculateSurface());
            //var sq1 = new Square(4.5);
            //Console.WriteLine(sq1);

            TestProces.Test();
        }
    }
}
