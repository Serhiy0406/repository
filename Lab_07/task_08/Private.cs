using System;
using System.Collections.Generic;
using System.Text;
using task_08.Interfaces;

namespace task_08
{
    class Privates:Soldier,IPrivate
    {
        private float salary;
        public float Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public Privates(int id, string fn, string ln, float salary)
            :base(id,fn,ln)
        {
            Salary = salary;
        }
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.Append($"{base.ToString()} Salary: {Salary:f2}");
            return resultBuilder.ToString();
        }
    }
}
