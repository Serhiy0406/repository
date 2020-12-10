using System;
using System.Collections.Generic;
using System.Text;

namespace task_5
{
    abstract class Person
    {
        public string Name { get; set; }
        public abstract int Amount { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public abstract void KingIsAttacked();
    }
}
