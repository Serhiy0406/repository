using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace task_05
{
    class Citizen: Society, IChecking
    {
        private int age;
        private string birthdate;
        public string Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Citizen(string name, int age, string id, string birthdate)
            :base(name, id)
        {
            Age = age;
            Birthdate = birthdate;
        }
        public bool Check(string part)
        {
            return Birthdate.EndsWith(part);
        }
    }
}
