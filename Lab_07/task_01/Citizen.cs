using System;
using System.Collections.Generic;
using System.Text;

namespace task_01
{
    class Citizen:IPerson, IIdentifiable, IBirthable
    {
        private string name;
        private int age;
        private string birthdate;
        private string id;
        public string Name 
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public int Age 
        {
            get { return age; }
            set
            {
                age = value;
            }
        }
        public string Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }
        public string Birthdate
        {
            get { return birthdate; }
            set
            {
                birthdate = value;
            }
        }
        public Citizen(string name, int age, string id, string birth)
        {
            Name = name;
            Age = age;
            Birthdate = birth;
            Id = id;
        }
    }
}
