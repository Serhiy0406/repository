using System;
using System.Collections.Generic;
using System.Text;

namespace task_11
{
    class Specialty
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public Specialty(string name, int number)
        {
            Name = name;
            Number = number;
        }
    }
}
