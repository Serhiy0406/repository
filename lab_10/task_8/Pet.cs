using System;
using System.Collections.Generic;
using System.Text;

namespace task_8
{
    class Pet
    {
        private string name;
        private int age;
        private string kind;
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length >= 1 && value.Length <= 50) { name = value; }
                else { throw new Exception("Invalid input of name"); }
            }
        }
        public string Kind
        {
            get { return kind; }
            set
            {
                if (value.Length >= 1 && value.Length <= 50) { kind = value; }
                else { throw new Exception("Invalid input of kind"); }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 1 && value <= 100) { age = value; }
                else { throw new Exception("Invalid input of age"); }
            }
        }
        public Pet(string name, int age, string kind)
        {
            Name = name;
            Age = age;
            Kind = kind;
        }
        public override string ToString()
        {
            return $"{Name} {Age} {Kind}";
        }
    }
}
