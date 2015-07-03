
    public struct Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static Point3D O = new Point3D() { X = 0, Y = 0, Z = 0 };

        //public Point3D (int X, int Y, int Z)
        //    :this()
        //{
        //    this.X = X;
        //    this.Y = Y;
        //    this.Z = Z;
        //}

        public override string ToString()
        {
            string point3DRepresent = string.Format("X = {0} / Y = {1} / Z = {2}", this.X, this.Y, this.Z);

            return point3DRepresent;
        }
    }

    

