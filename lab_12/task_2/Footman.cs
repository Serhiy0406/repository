using System;
using System.Collections.Generic;
using System.Text;

namespace task_2
{
    class Footman: Person
    {
        public override void KingIsAttacked()
        {
            Console.WriteLine($"Footman {Name} is panicking!");
        }
        public Footman(string name)
            : base(name)
        {
        }
    }
}
