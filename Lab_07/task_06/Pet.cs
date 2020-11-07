using System;
using System.Collections.Generic;
using System.Text;
using task_05;

namespace task_06
{
    class Pet: IChecking
    {
        private string name;
        private string birthdate;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }
        public Pet(string name , string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }
        public bool Check(string part)
        {
            return Birthdate.EndsWith(part);
        }
    }
}
