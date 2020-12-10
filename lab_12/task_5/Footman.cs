using System;
using System.Collections.Generic;
using System.Text;

namespace task_5
{
    class Footman: Person
    {
        public override int Amount { get; set; } = 2;
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
