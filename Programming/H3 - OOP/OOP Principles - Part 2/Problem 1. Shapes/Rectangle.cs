using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemShapesX
{
    class Rectangle : Shape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {
            
        }

        public override double CalculateSurface()
        {
            return base.Width * base.Height;
        }

        public override string ToString()
        {
            return String.Format("Rectangle - width = {0}, height = {1}, area = {2}", this.Width, this.Height, this.CalculateSurface());
        }
    }
}
