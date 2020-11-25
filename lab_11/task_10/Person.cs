using System;
using System.Collections.Generic;
using System.Text;

namespace task_10
{
    class Person
    {
        private string name;
        private int group;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Group
        {
            get { return group; }
            set { group = value; }
        }
        public Person(string name, int group)
        {
            Name = name;
            Group = group;
        }
    }
}
