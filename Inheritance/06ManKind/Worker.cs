namespace _06ManKind
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private decimal salary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal salary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.Salary = salary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public override string LastName
        {
            get => base.LastName;

            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException("Expected length more than 3 symbols!Argument: lastName");
                }
                base.LastName = value;
            }

        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.salary = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Week Salary: {this.salary:f2}")
                .AppendLine($"Hours per day: {this.workHoursPerDay:f2}")
                .Append($"Salary per hour: {this.CalcWeekSalaryPerHour():f2}");
            return base.ToString() + sb.ToString();
        }

        private decimal CalcWeekSalaryPerHour()
        {
            decimal salary = this.salary / (5 * this.workHoursPerDay);
            return salary;
        }
    }
}
