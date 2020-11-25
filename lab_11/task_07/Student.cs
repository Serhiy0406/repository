using System;
using System.Collections.Generic;
using System.Text;

namespace task_07
{
    class Student
    {
        private string firstname;
        private string lastname;
        public List<int> Marks { get; set; } = new List<int>();
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        
        public Student(string firstname, string lastname, int mark1, int mark2, int mark3, int mark4)
        {
            FirstName = firstname;
            LastName = lastname;
            Marks.Add(mark1);
            Marks.Add(mark2);
            Marks.Add(mark3);
            Marks.Add(mark4);
        }
    }
}
