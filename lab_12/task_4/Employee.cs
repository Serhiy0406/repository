using System;
using System.Collections.Generic;
using System.Text;

namespace task_4
{
    abstract class Employee
    {
        public string Name { get; set; }
        public abstract int WorkHoursPerWeek {get;}
        public Employee (string name)
        {
            Name = name;
        }
    }
}
