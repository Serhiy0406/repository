using System;
using System.Collections.Generic;
using System.Text;

namespace task_04
{
    class Student
    {
        private string firstname;
        private string lastname;
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
        public Student(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
    }
}
