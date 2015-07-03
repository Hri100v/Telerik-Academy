using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemShapesX
{
    public abstract class Shape
    {
        // abstract method CalculateSurface() and fields width and height
        //int width;
        //int height;
        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }

        public abstract double CalculateSurface();
    }
}
