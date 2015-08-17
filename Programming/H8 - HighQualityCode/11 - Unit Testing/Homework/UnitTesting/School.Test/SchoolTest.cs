using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Test
{
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void Test_SchoolShouldNotThrowException()
        {
            var school = new School("Telerik Academy");
        }

        [TestMethod]
        public void Test_SchoolShouldReturnNameCorrectly()
        {
            var school = new School("Telerik Academy");
            Assert.AreEqual("Telerik Academy", school.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_SchoolShouldThrowExceptionWhenNameIsNull()
        {
            var school = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_SchoolShouldThrowExceptionWhenNameIsEmpty()
        {
            var school = new School(string.Empty);
        }

        [TestMethod]
        public void Test_SchoolShouldAddStudentCorrectly()
        {
            var school = new School("Telerik Academy");
            var student = new Student("Pepi", 10000);
            school.AddStudent(student);
            Assert.AreSame(student, school.Students.First());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_SchoolShouldThrowExceptionWhenNullStudentAdded()
        {
            var school = new School("Telerik Academy");
            Student student = null;
            school.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test_SchoolShouldThrowExceptionWhenAddingExistingStudent()
        {
            var school = new School("Telerik Academy");
            var student = new Student("Georgi", 10000);
            school.AddStudent(student);
            school.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_SchoolShouldThrowExceptionWhenAddingStudentWithDuplicateId()
        {
            var school = new School("Telerik Academy");
            var student = new Student("Pepo", 54321);
            var otherStudent = new Student("Joro", 54321);
            school.AddStudent(student);
            school.AddStudent(otherStudent);
        }

        [TestMethod]
        public void Test_SchoolShouldAddCourseCorrectly()
        {
            var school = new School("Telerik Academy");
            var course = new Course("HQC");
            school.AddCourse(course);
            Assert.AreSame(course, school.Courses.First());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_SchoolShouldThrowExceptionWhenNullCourseAdded()
        {
            var school = new School("Telerik Academy");
            Course course = null;
            school.AddCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test_SchoolShouldThrowExceptionWhenExistingCourseAdded()
        {
            var school = new School("Telerik Academy");
            var course = new Course("HQC");
            school.AddCourse(course);
            school.AddCourse(course);
        }

        [TestMethod]
        public void Test_SchoolShouldRemoveStudentCorrectly()
        {
            var school = new School("Telerik Academy");
            var student = new Student("Pesho", 10000);
            school.AddStudent(student);
            school.RemoveStudent(student);
            Assert.IsTrue(school.Students.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_SchoolShouldThrowExceptionWhenRemovingNullStudent()
        {
            var school = new School("Telerik Academy");
            Student student = null;
            school.RemoveStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test_SchoolShouldThrowExceptionWhenRemovingNotExistingStudent()
        {
            var school = new School("Telerik Academy");
            var student = new Student("Pesho", 10000);
            school.RemoveStudent(student);
        }

        [TestMethod]
        public void Test_SchoolShouldRemoveCourseCorrectly()
        {
            var school = new School("Telerik Academy");
            var course = new Course("HQC");
            school.AddCourse(course);
            school.RemoveCourse(course);
            Assert.IsTrue(school.Courses.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_SchoolShouldThrowExceptionWhenRemovingNullCourse()
        {
            var school = new School("Telerik Academy");
            Course course = null;
            school.RemoveCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test_SchoolShouldThrowExceptionWhenRemovingNotExistingCourse()
        {
            var school = new School("Telerik Academy");
            var course = new Course("HQC");
            school.RemoveCourse(course);
        }
    }
}
