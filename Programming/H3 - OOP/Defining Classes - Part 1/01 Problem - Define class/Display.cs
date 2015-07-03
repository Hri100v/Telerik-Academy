using System;

namespace ClassDisplay
{
    internal class Display
    {
        // display characteristics (size and number of colors)
        private double size;
        private byte numberColor;

        public Display() { }

        public Display(double size, byte numberColor)
        {
            this.size = size;
            this.numberColor = numberColor;
        }

        public double Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public byte NumberColor
        {
            get { return this.numberColor; }
            set { this.numberColor = value; }
        }

    }
}
