using System;

namespace DefiningClasses1
{
    public class Display
    {
        // display characteristics (size and number of colors)
        private double size;
        private uint colorNum;
        
        public Display(double size)
        {
            this.Size = size;
        }

        public Display(double size, uint colorNum)
        {
            this.Size = size;
            this.ColorNum = colorNum;
        }
        
        public double Size
        {
            get { return this.size; }
            private set { this.size = value; }
        }

        public uint ColorNum
        {
            get { return this.colorNum; }
            private set { this.colorNum = value; }
        }

        public override string ToString()
        {
            
            return String.Format("size - {0} \n\t\tnumber of colors - {1}", this.Size, this.ColorNum);
        }
    }
}
