using System;
using System.Collections.Generic;
using System.Text;

namespace task_4
{
    class JobEventArgs: EventArgs
    {
        public string Name { get; set; }
        public int HoursRequired { get; set; }
        public Employee Employee { get; set; }
        public JobEventArgs(string name, int hours, Employee employee)
        {
            Name = name;
            HoursRequired = hours;
            Employee = employee;
        }
    }
}
