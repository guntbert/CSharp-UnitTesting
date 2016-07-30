namespace School
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        private string name;
        private int number;
        private static IList<int> numbers;


        static Student()
        {
            numbers = new List<int>();
        }

        public Student(string name, int number)
        {
            this.ValidateEnteredData<string>(name);
            this.ValidateEnteredData<int>(number);
           
            this.name = name;
            this.number = number;

            numbers.Add(number);
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int Number
        {
            get
            {
                return this.number;
            }
        }

        public void ValidateEnteredData<T>(T data)
        {
            if (typeof(T) == typeof(string) && data == null)
            {
                throw new ArgumentNullException("Name cannot be null.");
            }
            else if (typeof(T) == typeof(int) && ((Convert.ToInt32(data) < 10000) || (Convert.ToInt32(data) > 99999)))
            {
                throw new ArgumentOutOfRangeException("The specified number should be in the range of 10000 - 99999");
            }
            else if ((typeof(T) == typeof(int)) && (numbers.Contains(Convert.ToInt32(data))))
            {
                throw new ArgumentException("Student's faculty number should be unique.");
            }
        }
    }
}
