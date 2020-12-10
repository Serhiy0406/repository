using System;
using System.Collections.Generic;
using System.Text;

namespace task_4
{
    class PartTimeEmployee: Employee
    {
        public override int WorkHoursPerWeek { get; } = 20;
        public PartTimeEmployee(string name)
            : base(name)
        {
        }
    }
}
