using System;
using System.Collections.Generic;
using System.Text;

namespace task_6
{
    class Person
    {
        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length>=1 && value.Length<=50) { name = value; }
                else { throw new Exception("Invalid input of name"); }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value>= 1 && value <= 100) { age = value; }
                else { throw new Exception("Invalid input of age"); }
            }
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }
}
