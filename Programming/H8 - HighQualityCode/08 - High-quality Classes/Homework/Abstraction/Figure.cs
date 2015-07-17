using System;
using System.Text;

namespace Abstraction
{
    abstract class Figure
    {
        public Figure(double width, double height)
        {
            if (width <= 0)
            {
                throw new ArgumentException("Width cannot be negative or zero.");
            }

            if (height <= 0)
            {
                throw new ArgumentException("Height cannot be negative or zero.");
            }

            this.Width = width;
            this.Height = height;
        }

        public virtual double Width { get; protected set; }
        public virtual double Height { get; protected set; }

        public abstract double CalcPerimeter();
        public abstract double CalcSurface();

        public override string ToString()
        {
            StringBuilder representObject = new StringBuilder();
            representObject.AppendLine(this.GetType().Name);
            representObject.AppendLine(String.Format("My perimeter is {0:f2}. My surface is {1:f2}.", this.CalcPerimeter(), this.CalcSurface()));
            representObject.AppendLine("==============");
            return representObject.ToString();
        }

    }
}
