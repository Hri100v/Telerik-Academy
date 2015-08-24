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

        public int Row
        {
            get
            { 
                return this.row; 
            }
 
            set
            {
                Validator.ValidateRowsAndCols(value, "Row");
                this.row = value;
            }
        }

        public int Col
        {
            get
            {
                return this.col;
            }

            set
            {
                Validator.ValidateRowsAndCols(value, "Col");

                this.col = value;
            }
        }

    }
}
