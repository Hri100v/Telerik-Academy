namespace RotatingWalkInMatrix
{
    using System;

    public static class Validator
    {
        public static void ValidateRowsAndCols(int valueRowCol, string elementRowCol)
        {
            if (valueRowCol < 0)
            {
                throw new ArgumentException(String.Format("{0} cannot be negative!", elementRowCol));
            }
        }
    }
}
