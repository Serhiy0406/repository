using System;
using System.Collections.Generic;
using System.Text;

namespace task_14
{
    class Cat
    {
        public string Name { get; set; }
        public virtual void PrintOut()
        {
            Console.WriteLine($"{Name}");
        }
        public Cat (string name)
        {
            Name = name;
        }
    }
}
