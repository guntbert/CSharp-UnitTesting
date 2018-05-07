// RE try something in a new branch
namespace School
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private const byte MaxStudentsInCourse = 30;

        public Course()
        {
            this.Students = new List<Student>();
        }

        public Course(Student student)
        {
            this.Students = new List<Student>();
            this.Students.Add(student);
        }

        public Course(Student[] studentsArr)
        {
            if (studentsArr.Length > MaxStudentsInCourse)
            {
                throw new ArgumentOutOfRangeException("The specified set of students is larger than the maximum number allowed.");
            }
            else
            {
                this.Students = new List<Student>();
                for (int i = 0; i < studentsArr.Length; i++)
                {
                    this.Students.Add(studentsArr[i]);
                } 
            }
        }

        public IList<Student> Students { get; private set; }

        public void AddStudent(Student student)
        {
            if (this.Students.Count == 30)
            {
                throw new InvalidOperationException("Cannot add more than 30 students to course.");
            }
            else
            {
                this.Students.Add(student);
            }
        }
        
        public void RemoveStudent(Student student)
        {
            if ((this.Students.Count != 0) && (this.Students.Contains(student)))
            {
                this.Students.Remove(student);
            }
            else
            {
                throw new InvalidOperationException("Cannot remove the specified student. Please, make sure that the student exists.");
            }
        }
    }
}
