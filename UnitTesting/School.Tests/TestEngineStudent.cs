namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestEngineStudent
    {
        [TestMethod]
        public void Constructor_CreateStudentWithCorrectNameAndNumber_ShouldSuccessfullyCreateStudent()
        {
            Student student = new Student("Test Student", 52498);
            Assert.IsInstanceOfType(student, typeof(Student));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ValidateEnteredData_CreateStudentWithNullName_ShouldThrowNullException()
        {
            Student student = new Student(null, 8222);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidateEnteredData_CreateStudentWithNumberOutOfUpperBond_ShouldThrowArgumentOutOfRange()
        {
            Student student = new Student("Test Student", 100000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidateEnteredData_CreateStudentWithNumberOutOfLowerBond_ShouldThrowArgumentOutOfRange()
        {
            Student student = new Student("Test Student", 9999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateEnteredData_CreateStudentsWithIdenticalNumbers_ShouldThrowArgumentException()
        {
            Student firstStudent = new Student("Test Student", 44444);
            Student secondStudent = new Student("Second Test Student", 44444);
        }

        [TestMethod]
        public void PropertyName_SetAName_ShouldReturnValueCorrectly()
        {
            Student student2 = new Student("Test", 52337);
            Assert.AreEqual("Test", student2.Name);
        }

        [TestMethod]
        public void PropertyNumber_SetANumber_ShouldReturnValueCorrectly()
        {
            Student student = new Student("Test Student", 49990);
            Assert.AreEqual(49990, student.Number);
        }
    }
}
