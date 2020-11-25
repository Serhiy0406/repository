using System;
using System.Collections.Generic;
using System.Text;

namespace task_06
{
    class Student
    {
        private string firstname;
        private string lastname;
        private string phone;
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
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public Student(string firstname, string lastname, string phone)
        {
            FirstName = firstname;
            LastName = lastname;
            Phone = phone;
        }
    }
}
