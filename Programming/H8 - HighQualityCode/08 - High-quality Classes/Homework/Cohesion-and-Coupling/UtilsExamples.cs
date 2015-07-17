using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            {
                Console.WriteLine(FilesUtils.GetFileExtension("example"));
                Console.WriteLine(FilesUtils.GetFileExtension("example.pdf"));
                Console.WriteLine(FilesUtils.GetFileExtension("example.new.pdf"));

                Console.WriteLine(FilesUtils.GetFileName("example"));
                Console.WriteLine(FilesUtils.GetFileName("example.pdf"));
                Console.WriteLine(FilesUtils.GetFileName("example.new.pdf"));
            }

            {
                Console.WriteLine("Distance in the 2D space = {0:F2}",
                    GeometryUtils.CalcDistance2D(1, -2, 3, 4));

                Console.WriteLine("Distance in the 3D space = {0:F2}",
                    GeometryUtils.CalcDistance3D(5, 2, -1, 3, -6, 4));
            }

            {
                FigureGeometry figureGeometry = new FigureGeometry()
                {
                    Width = 3,
                    Height = 4,
                    Depth = 5
                };

                Console.WriteLine("Volume = {0:F2}", figureGeometry.Volume);

                Console.WriteLine("Diagonal XY = {0:F2}", figureGeometry.CalcDiagonalXY());
                Console.WriteLine("Diagonal YZ = {0:F2}", figureGeometry.CalcDiagonalYZ());
                Console.WriteLine("Diagonal XZ = {0:F2}", figureGeometry.CalcDiagonalXZ());

                Console.WriteLine("Diagonal XYZ = {0:F2}", figureGeometry.CalcDiagonalXYZ());
            }
        }
    }
}
