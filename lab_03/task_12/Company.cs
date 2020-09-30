using System;
using System.Collections.Generic;
using System.Text;

namespace task_12
{
    class Company
    {
        private string name;
        private string department;
        private float salary;
        public string Name { get; set; }
        public string Department { get; set; }
        public float Salary { get; set; }
        public Company(string name, string department, float salary)
        {
            Name = name;
            Department = department;
            Salary = salary;
        }
    }
}
