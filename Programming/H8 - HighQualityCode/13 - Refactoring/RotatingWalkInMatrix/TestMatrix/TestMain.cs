namespace TestMatrix
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using RotatingWalkInMatrix;
    using System.IO;
    using System.Text;

    [TestClass]
    public class TestMain
    {
        [TestMethod]
        public void TestMatrixConsoleOutputShouldBeAsExpectedWhenAValidMatrixIsCreated()
        {
            using (StringWriter testStringWriter = new StringWriter())
            {
                Console.SetOut(testStringWriter);
                RotatingWalkInMatrixEngine.Main();
                Matrix testMatrix = new Matrix(4);
                StringBuilder expected = new StringBuilder();
                for (int i = 0; i < testMatrix.Field.GetLength(0); i++)
                {
                    for (int j = 0; j < testMatrix.Field.GetLength(0); j++)
                    {
                        expected.AppendFormat("{0,3}", testMatrix.Field[i, j]);
                    }

                    expected.Append(Environment.NewLine);
                }
                expected.Append(Environment.NewLine);
                string expectedString = expected.ToString();

                Assert.AreEqual(expectedString, testStringWriter.ToString());
            }
        }
    }
}
