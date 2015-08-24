namespace RotatingWalkInMatrix
{
    using System;
    using System.Text;

    public class Matrix
    {
        public const int NUMBERS_DIRECTIONS = 8;
        public readonly Coordinates[] targetDirections;
        public int currentTargetIndex;
        private int size;

        /// <summary>
        /// That is "Square Matrix" and the size is same in two dimensions
        /// </summary>
        /// <param name="size">Size of the matrix</param>
        /// <return>Filled matrix</return>
        public Matrix(int size)
        {
            this.Size = size;
            this.Field = new int[size, size];
            this.targetDirections = new Coordinates[]
                {
                    new Coordinates(1, 1), new Coordinates(1, 0), new Coordinates(1, -1), new Coordinates(0, -1),
                    new Coordinates(-1, -1), new Coordinates(-1, 0), new Coordinates(-1, 1), new Coordinates(0, 1)
                };
            this.currentTargetIndex = 0;
            this.FillMatrix();
        }

        /// <exception cref="ArgumentOutOfRangeException">Size cannot be less than or equal to zero</exception>
        public int Size
        {
            get
            {
                return this.size;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Size cannot be equal or less than zero!");
                }

                this.size = value;
            }
        }

        public int[,] Field { get; set; }

        private void FillMatrix()
        {
            var target = new Coordinates(0, 0);
            var accumulate = 1;

            while (target != null)
            {
                this.Field[target.Row, target.Col] = accumulate;
                target = this.Walk(target) ?? this.FindFirstEmptyTarget();
                accumulate++;
            }
        }

        private Coordinates FindFirstEmptyTarget()
        {
            int rows = this.Field.GetLength(0);
            int columns = this.Field.GetLength(1);

            Coordinates newTarget = new Coordinates(0, 0);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    if (this.Field[row, col] == 0)
                    {
                        this.currentTargetIndex = 0;
                        newTarget.Row = row;
                        newTarget.Col = col;
                        return newTarget;
                    }
                }
            }

            return null;
        }

        private Coordinates Walk(Coordinates target)
        {
            for (int index = this.currentTargetIndex; index < NUMBERS_DIRECTIONS + this.currentTargetIndex; index++)
            {
                int newTargetIndex = index % NUMBERS_DIRECTIONS;
                Coordinates nextTarget = target + this.targetDirections[newTargetIndex];
                if (this.IsValidWalk(nextTarget))
                {
                    this.currentTargetIndex = newTargetIndex;
                    return nextTarget;
                }
            }

            return null;
        }

        private bool IsValidWalk(Coordinates checkTarget)
        {
            int size = this.Size;

            return checkTarget.Row >= 0 && checkTarget.Row < size &&
                    checkTarget.Col >= 0 && checkTarget.Col < size &&
                    this.Field[checkTarget.Row, checkTarget.Col] == 0;
        }

        public override string ToString()
        {
            StringBuilder matrixToString = new StringBuilder();
            for (int row = 0; row < this.Size; row++)
            {
                for (int col = 0; col < this.Size; col++)
                {
                    matrixToString.AppendFormat("{0,3}", this.Field[row, col]);
                }
                matrixToString.AppendLine();
            }

            return matrixToString.ToString();
        }

    }
}
