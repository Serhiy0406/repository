using System;
using System.Collections.Generic;
using System.Text;

namespace task_01
{
    class Student
    {
        private string firstname;
        private string lastname;
        private int group;
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
        public int Group
        {
            get { return group; }
            set { group = value; }
        }
        public Student(string firstname, string lastname, int group)
        {
            FirstName = firstname;
            LastName = lastname;
            Group = group;
        }
    }
}
