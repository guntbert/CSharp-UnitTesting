namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestEngineSchool
    {
        [TestMethod]
        public void Constructor_CreateSuccessfully_CreatingNewSchool()
        {
            Student firstStudent = new Student("First Student", 25843);
            Student secondStudent = new Student("Second Student", 35128);
            Course mathematics = new Course();
            mathematics.AddStudent(firstStudent);
            mathematics.AddStudent(secondStudent);
            School school = new School(mathematics);
            Assert.IsInstanceOfType(school, typeof(School));
        }

        [TestMethod]
        public void Constructor_CreateSuccessfully_CreatingNewSchoolFromArrayOfCourses()
        {
            Student firstStudentCourseOne = new Student("First Student Course One", 25310);
            Student secondStudentCourseOne = new Student("Second Student Course One", 25311);
            Student firstStudentCourseTwo = new Student("First Student Course Two", 25312);
            Student secondStudentCourseTwo = new Student("Second Student Course Two", 25313);
            Course firstCourse = new Course(new[] { firstStudentCourseOne, secondStudentCourseOne });
            Course secondCourse = new Course(new[] { firstStudentCourseTwo, secondStudentCourseTwo });
            School school = new School(new[] { firstCourse, secondCourse });
            Assert.IsInstanceOfType(school, typeof(School));
        }

        [TestMethod]
        public void PropertyCourse__ReturnCorrectNumberOfCourses_CreatingSchoolFromArrayOfCourses()
        {
            Student firstStudentCourseOne = new Student("First Student Course One", 26430);
            Student secondStudentCourseOne = new Student("Second Student Course One", 25431);
            Student firstStudentCourseTwo = new Student("First Student Course Two", 25432);
            Student secondStudentCourseTwo = new Student("Second Student Course Two", 25433);
            Course firstCourse = new Course(new[] { firstStudentCourseOne, secondStudentCourseOne });
            Course secondCourse = new Course(new[] { firstStudentCourseTwo, secondStudentCourseTwo });
            School school = new School(new[] { firstCourse, secondCourse });
            Assert.AreEqual(2, school.Courses.Count);
        }
    }
}
