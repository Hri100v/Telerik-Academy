namespace RotatingWalkInMatrix
{
    using log4net;
    using log4net.Config;
    using System;

    class WalkInMatrix
    {
        
        static void Main(string[] args)
        {
            #region first
            //Console.WriteLine("Enter a positive number ");
            //string input = Console.ReadLine();
            //int dimension = 0;
            //while (!int.TryParse(input, out dimension) || dimension < 0 || dimension > 100)
            //{
            //    Console.WriteLine("You haven't entered a correct positive number!");
            //    input = Console.ReadLine();
            //}

            //FillMatrix matrix = new FillMatrix(dimension);

            //int vertical = 0;
            //int horizontal = 0;

            //matrix.FillMatrixWithNumbers(vertical, horizontal, dimension);

            //matrix.FindEmptyCell(out vertical, out horizontal);

            //if (vertical != 0 && horizontal != 0)
            //{
            //    matrix.FillMatrixWithNumbers(vertical, horizontal, dimension);
            //}

            //matrix.PrintMatrix();
            #endregion

            //ILog Log = LogManager.GetLogger(typeof(Log4NetExample));
            ILog Log = LogManager.GetLogger("Logger for matrix");
        
            //XmlConfigurator.Configure();
            //Log.Info("Info logging");
            //try
            //{
            //    throw new Exception("Exception!");
            //}
            //catch (Exception e)
            //{
            //    Log.Error("This is my error", e);
            //}

            //Console.WriteLine("[any key to exit]");
            //Console.ReadKey();

            SquareMatrix matrix = new SquareMatrix(8);
            matrix.RotatingWalkFill();
            Console.WriteLine(matrix);
            var matrixToString = matrix.ToString();
            Log.InfoFormat("Print Matrix \n {0}", matrixToString);
        }
    }
}
