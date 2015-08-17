using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Test
{
    [TestClass]
    public class StudentTest
    {
        string name;
        string nameEmpty = String.Empty;
        int id;
        int idLowBound;
        int idHighBound;

        [TestInitialize]
        public void BeforeEachTests()
        {
            name = "Pesho";
            id = 54321;
            idLowBound = 10000;
            idHighBound = 99999;
        }
        

        [TestMethod]
        public void Test_CreateStudent_ShoudNotThrow_AnException()
        {
            Student student = new Student(name, id);
        }

        [TestMethod]
        public void Test_CreateStudentWithLowerBoundary()
        {
            Student student = new Student(name, idLowBound);
        }

        [TestMethod]
        public void Test_CreateStudentWithHigherBoundary()
        {
            Student student = new Student(name, idHighBound);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_CreateStudentWithInvalidName()
        {
            Student student = new Student(nameEmpty, id);
        }

        [TestMethod]
        public void Test_ShouldReturnExpectedName()
        {
            var expectedName = "Pesho";
            var student = new Student(name, id);
            Assert.AreEqual(expectedName, student.Name);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_ShouldThrowExceptionNullNameValue()
        {
            var student = new Student(null, id);
        }

        [TestMethod]
        public void Test_ShouldReturnExpectedId()
        {
            var expectedId = 54321;
            var student = new Student(name, id);
            Assert.AreEqual(expectedId, student.ID);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_ShouldThrowExceptionFromInvlidIdNumberHigher()
        {
            var higherId = 654321;
            var student = new Student(name, higherId);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_ShouldThrowExceptionFromInvlidIdNumberLower()
        {
            var lowerId = 4321;
            var student = new Student(name, lowerId);
        }

        [TestMethod]
        public void Test_MethodCompareTo()
        {
            // Arrange
            var anotherStudent = new Student(name, id + 1);
            var student = new Student(name, id);

            // Act
            var result = student.CompareTo(anotherStudent) < 0;

            // Assert
            Assert.IsTrue(result);
        }
    }
}
