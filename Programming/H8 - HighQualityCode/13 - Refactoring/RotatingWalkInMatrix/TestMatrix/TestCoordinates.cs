namespace TestMatrix
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using RotatingWalkInMatrix;

    [TestClass]
    public class TestCoordinates
    {
        private Coordinates first = new Coordinates(1, 2);
        private Coordinates second = new Coordinates(2, 1);

        [TestMethod]
        public void AddingTwoCoordinatesShouldReturnANewCoordinateWithProperValuesForRowAndCol()
        {
            Coordinates resulting = first + second;

            Assert.AreEqual(3, resulting.Row, "resulting.Row should be equal to firstCell.Row + secondCell.Row");
            Assert.AreEqual(3, resulting.Col, "resulting.Col should be equal to firstCell.Col + secondCell.Col");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingTwoCoordinatesShouldThrowAnArgumentNullExceptionWhenEitherOfTheOperandsIsNull()
        {
            Coordinates test = this.first + null;
        }
    }
}
