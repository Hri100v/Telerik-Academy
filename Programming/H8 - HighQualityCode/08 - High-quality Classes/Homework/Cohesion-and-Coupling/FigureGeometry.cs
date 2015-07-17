using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling
{
    class FigureGeometry
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }

        public double Volume
        {
            get { return this.Width * this.Height * this.Depth; }
        }

        public double CalcDiagonalXYZ()
        {
            return GeometryUtils.CalcDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
        }

        public double CalcDiagonalXY()
        {
            return GeometryUtils.CalcDistance2D(0, 0, this.Width, this.Height);
        }

        public double CalcDiagonalXZ()
        {
            return GeometryUtils.CalcDistance2D(0, 0, this.Width, this.Depth);
        }

        public double CalcDiagonalYZ()
        {
            return GeometryUtils.CalcDistance2D(0, 0, this.Height, this.Depth);
        }
    }
}
