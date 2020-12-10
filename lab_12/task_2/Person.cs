using System;
using System.Collections.Generic;
using System.Text;

namespace task_2
{
    abstract class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public abstract void KingIsAttacked();
    }
}
