using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemShapesX
{
    class Triangle : Shape
    {
        public Triangle(double width, double height)
            : base(width, height)
        {
            
        }

        public override double CalculateSurface()
        {
            return base.Width / 2D * base.Height;
        }

        public override string ToString()
        {
            return String.Format("Triangle - width = {0}, height = {1}, area = {2}", this.Width, this.Height, this.CalculateSurface());
        }
    }
}
