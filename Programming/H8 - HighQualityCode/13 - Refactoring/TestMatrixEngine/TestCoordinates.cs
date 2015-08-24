namespace RotatingWalkInMatrix
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using RotatingWalkInMatrix;

    [TestClass]
    public class TestCoordinates
    {
        [TestMethod]
        public void InputRightValue_ShouldWorkCorrectly()
        {
            Coordinates cell = new Coordinates(1, 1);
        }

        [TestMethod]
        public void InputBoundValue_ShouldWorkCorrectly()
        {
            Coordinates cellFirst = new Coordinates(0, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InputIncorrectValue_ShouldThrowException()
        {
            Coordinates cellA = new Coordinates(-1, 0);
            Coordinates cellB = new Coordinates(0, -4);
        }
    }
}
