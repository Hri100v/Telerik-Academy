using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Test
{
    [TestClass]
    public class CourseTest
    {
        string nameMath;
        Student student;

        [TestInitialize]
        public void BeforeEachCourseTests()
        {
            nameMath = "Mathematics";
            student = new Student("Pesho", 12345);
        }

        [TestMethod]
        public void Test_Course_ConstructorShoudCreated()
        {
            Course course = new Course(nameMath);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Course_ShoudThrowExceptionCreatedInvalidName()
        {
            Course course = new Course(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Course_AddStudentMethodForIncorrectInstanceNull()
        {
            Course course = new Course(nameMath);
            course.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_Course_AddStudentMethodForOutOfRange()
        {
            Course course = new Course(nameMath);
            var id = 10000;
            for (int i = 0; i < 40; i++)
            {
                course.AddStudent(new Student("Petyr", id + i));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test_Course_AddStudentMethodForDoubleOfStudents()
        {
            Course course = new Course(nameMath);
            course.AddStudent(student);
            course.AddStudent(student);
        }

        [TestMethod]
        public void Test_Course_RemoveStudent()
        {
            Course course = new Course(nameMath);
            Student student = new Student("Nikodim", 77777);
            course.AddStudent(student);
            course.RemoveStudent(student);
            Assert.AreEqual(0, course.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Course_ThrowExceptionWhenRemovingNullStudent()
        {
            var course = new Course(nameMath);
            Student student = null;
            course.RemoveStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test_Course_ThrowExceptionWhenRemovingUnexistingStudent()
        {
            var course = new Course(nameMath);
            Student student = new Student("Pesho", 10000);
            course.RemoveStudent(student);
        }
    }
}
