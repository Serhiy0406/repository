using System;
using System.Collections.Generic;
using System.Text;

namespace task_5
{
    class RoyalGuard: Person
    {
        public override int Amount { get; set; } = 3;
        public override void KingIsAttacked()
        {
            Console.WriteLine($"Royal Guard {Name} is defending!");
        }
        public RoyalGuard(string name)
            : base(name)
        {
        }
    }
}
