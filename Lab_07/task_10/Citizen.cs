using System;
using System.Collections.Generic;
using System.Text;

namespace task_10
{
    class Citizen:IPerson,IREsident
    {
        private string name;
        private int age;
        private string country;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        string IPerson.GetName()
        {
           return($"{Name}");
        }
        string IREsident.GetName()
        {
            return($"Mr/Ms/Mrs {Name}");
        }
        public Citizen(string name, string country, int age)
        {
            Name = name;
            Country = country;
            Age = age;
        }
    }
}
