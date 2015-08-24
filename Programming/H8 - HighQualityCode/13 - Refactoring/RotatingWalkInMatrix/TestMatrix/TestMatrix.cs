namespace TestMatrix
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using RotatingWalkInMatrix;

    [TestClass]
    public class TestMatrix
    {
        [TestMethod]
        public void TestMatrixWithSizeOne_ShoudContainOnlyOneMember_WithValueOne()
        {
            Matrix testMatrix = new Matrix(1);
            Assert.AreEqual(1, testMatrix.Field[0, 0]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMatrixWithZeroSize_ShouldThrowException()
        {
            Matrix testMatrix = new Matrix(0);
        }

        [TestMethod]
        public void TestMatrixPropertySize()
        {
            Matrix testMatrix = new Matrix(3);
            bool areEqual = testMatrix.Size == 3;
            Assert.IsTrue(areEqual);
        }
        
        [TestMethod]
        public void TestMatrix_ShouldReturnCorrectMatrixOfSizeThree()
        {
            Matrix testMatrix = new Matrix(3);
            var actual = testMatrix.Field;
            var expected = new int[,] 
            { 
                { 1, 7, 8 },
                { 6, 2, 9 },
                { 5, 4, 3 }
            };

            Assert.IsTrue(this.MatricesAreEqual(expected, actual));
        }

        [TestMethod]
        public void TestMatrix_ShouldReturnCorrectMatrixOfSizeFour()
        {
            Matrix testMatrix = new Matrix(4);
            var actual = testMatrix.Field;
            var expected = new int[,] 
            { 
                { 1, 10, 11, 12 },
                { 9, 2,  15, 13 },
                { 8, 16, 3,  14 },
                { 7, 6,  5,  4  }
            };

            Assert.IsTrue(this.MatricesAreEqual(expected, actual));
        }

        private bool MatricesAreEqual(int[,] expected, int[,] actual)
        {
            if (expected.GetLength(0) != actual.GetLength(0) || expected.GetLength(1) != actual.GetLength(1))
            {
                return false;
            }

            for (int row = 0; row < expected.GetLength(0); row++)
            {
                for (int col = 0; col < expected.GetLength(1); col++)
                {
                    if (expected[row, col] != actual[row, col])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
