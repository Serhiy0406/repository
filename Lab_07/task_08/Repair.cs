using System;
using System.Collections.Generic;
using System.Text;

namespace task_08
{
    class Repair
    {
        private string partname;
        private int hours;
        public string Partname
        {
            get { return partname; }
            set { partname = value; }
        }
        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }
        public Repair(string partname, int hours)
        {
            Partname = partname;
            Hours = hours;
        }
    }
}
