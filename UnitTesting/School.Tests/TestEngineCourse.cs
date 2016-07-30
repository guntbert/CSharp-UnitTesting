namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestEngineCourse
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_UseArrayWithMoreThanMaxStudents_ShouldThrowAnInvalidOperationException()
        {
            Student[] students = new Student[31];
            for (int i = 0; i < 31; i++)
            {
                students[i] = new Student(('a' + i).ToString(), 20000 + i);
            }

            Course course = new Course(students);
        }

        [TestMethod]
        public void Constructor_UseSingleStudent_ShouldCreateCourseSuccessfully()
        {
            Course course = new Course(new Student("Test Student", 85217));
            Assert.IsInstanceOfType(course, typeof(Course));
        }

        [TestMethod]
        public void PropertyStudents_CreateCourseFromArray_ShouldReturnCorrectStudentsCount()
        {
            Student[] students = new Student[20];
            for (int i = 0; i < 20; i++)
            {
                students[i] = new Student(('a' + i).ToString(), 25400 + i);
            }

            Course course = new Course(students);
            Assert.AreEqual(20, course.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddStudent_AddStudentToCourseWithMaxStudents_ShouldThrowAnInvalidOperationException()
        {
            Student[] students = new Student[30];
            for (int i = 0; i < 30; i++)
            {
                students[i] = new Student(('a' + i).ToString(), 21000 + i);
            }

            Course course = new Course(students);
            Student student = new Student("Test Student", 84528);
            course.AddStudent(student);
        }

        [TestMethod]
        public void AddStudent_AddsStudent_ShouldAddSuccessfully()
        {
            Course course = new Course();
            course.AddStudent(new Student("Test Student", 56123));
            Assert.AreEqual(1, course.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RemoveStudent_RemovesStudentThatDoesNotExist_ShouldThrowAnInvalidOperationException()
        {
            Student[] students = new Student[]
            {
                new Student("First Test Student", 23456),
                new Student("Second Test Student", 34567),
                new Student("Third Test Student", 45678)
            };
            Course course = new Course(students);
            course.RemoveStudent(new Student("Test Student", 68978));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RemoveStudent_RemoveStudentFromEmptyCourse_ShouldThrowAnInvalidOperationException()
        {
            Course course = new Course();
            course.RemoveStudent(new Student("Test Student", 48711));
        }

        [TestMethod]
        public void RemoveStudent_RemovesStudent_ShouldRemoveSuccessfully()
        {
            Student firstStudent = new Student("First Test Student", 78452);
            Student secondStudent = new Student("Second Test Student", 78453);
            Student thirdStudent = new Student("Third Test Student", 78454);

            Student[] students = new Student[]
            {
                firstStudent,
                secondStudent,
                thirdStudent
            };
            Course course = new Course(students);
            course.RemoveStudent(firstStudent);
            Assert.AreEqual(2, course.Students.Count);
        }
    }
}
