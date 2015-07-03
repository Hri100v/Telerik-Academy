using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemShapesX
{
    class Square : Shape
    {
        // suitable constructor so that at initialization height must be kept equal to width
        double size;

        public Square(double size)
            : base(size, size)
        {
            
        }

        public override double CalculateSurface()
        {
            return base.Width * base.Height;
        }

        public override string ToString()
        {
            return String.Format("Square - side = {0}, area = {2}", this.Width, this.Height, this.CalculateSurface());
        }
    }
}
