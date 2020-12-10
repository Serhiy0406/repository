using System;
using System.Collections.Generic;
using System.Text;

namespace task_4
{
    class Job
    {
        public event EventHandler<JobEventArgs> PassWeek;
        public JobEventArgs data;
        public Job(string name, int hours, Employee employee)
        {
            data = new JobEventArgs(name, hours, employee);        
        }
        public Job()
        {
        }
        public void Update()
        {
            data.HoursRequired -= data.Employee.WorkHoursPerWeek;
            OnPassWeek(data);
        }
        protected virtual void OnPassWeek(JobEventArgs e)
        {
            PassWeek?.Invoke(this, e);
        }
    }
}
