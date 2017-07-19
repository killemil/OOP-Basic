namespace _06ManKind
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return facultyNumber; }
            set
            {
                string pattern = @"^(\d+|\w+)$";
                if (!Regex.IsMatch(value, pattern))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                facultyNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Faculty number: {this.facultyNumber}");
            return base.ToString() + sb.ToString();
        }
    }
}
