using System;
using System.Collections.Generic;
using System.Text;

namespace task_3
{
    class Worker: Human
    {
        private double salary;
        private double hours;
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: {value}");
                }
                else { salary = value; }
            }
        }
        public double Hours
        {
            get { return hours; }
            set
            {
                if (value < 1 && value > 12)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: {value}");
                }
                else { hours = value; }
            }
        }
        public Worker(string firstname, string lastname, double salary, double hours)
            :base(firstname,lastname)
        {
            Salary = salary;
            Hours = hours;
        }
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine(base.ToString())
                .AppendLine($"Week Salary: {this.Salary:f2}")
                .AppendLine($"Hours per day: {this.Hours:f2}")
                .AppendLine($"Salary per hour: {this.Hours* this.Salary:f2}");
            return resultBuilder.ToString();
        }
    }
}
