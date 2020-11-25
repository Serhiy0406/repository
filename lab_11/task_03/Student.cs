using System;
using System.Collections.Generic;
using System.Text;

namespace task_03
{
    class Student
    {
        private string firstname;
        private string lastname;
        private int age;
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
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Student(string firstname, string lastname, int age)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
        }
    }
}
