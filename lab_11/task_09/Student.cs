using System;
using System.Collections.Generic;
using System.Text;

namespace task_09
{
    class Student
    {
        private string facultyNumber;
        public List<int> Marks { get; set; } = new List<int>();
        public string FacultyNumber
        {
            get { return facultyNumber; }
            set { facultyNumber = value; }
        }

        public Student(string number, int mark1, int mark2, int mark3, int mark4)
        {
            FacultyNumber = number;
            Marks.Add(mark1);
            Marks.Add(mark2);
            Marks.Add(mark3);
            Marks.Add(mark4);
        }
    }
}
