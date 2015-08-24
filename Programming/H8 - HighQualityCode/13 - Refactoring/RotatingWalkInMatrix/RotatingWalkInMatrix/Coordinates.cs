namespace RotatingWalkInMatrix
{
    using System;

    public class Coordinates
    {
        private int row;
        private int col;

        public Coordinates(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
                
        public int Row { get; set; }

        public int Col { get; set; }

        public static Coordinates operator +(Coordinates first, Coordinates second)
        {
            if (first == null || second == null)
            {
                throw new ArgumentNullException("Neither " + "operand cannot be null!");
            }

            return new Coordinates(first.Row + second.Row, first.Col + second.Col);
        }
    }
}
