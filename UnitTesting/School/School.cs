namespace School
{
    using System.Collections.Generic;

    public class School
    {

        public School(Course course)
        {
            this.Courses = new List<Course>();
            Courses.Add(course);
        }

        public School(Course[] courses)
        {
            this.Courses = new List<Course>();
            foreach (Course course in courses)
            {
                Courses.Add(course);
            }
        }

        public IList<Course> Courses { get; private set; }
    }
}
