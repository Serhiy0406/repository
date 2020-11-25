using System;
using System.Collections.Generic;
using System.Text;

namespace task_11
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; }
        public Student(int number, string firstn, string lastn)
        {
            FirstName = firstn;
            LastName = lastn;
            Number = number;
        }
    }
}
