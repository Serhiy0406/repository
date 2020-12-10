using System;
using System.Collections.Generic;
using System.Text;

namespace task_4
{
    class StandartEmployee: Employee
    {
        public override int WorkHoursPerWeek { get; } = 40;
        public StandartEmployee(string name)
            : base(name) 
        { 
        }
    }
}
