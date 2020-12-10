using System;
using System.Collections.Generic;
using System.Text;

namespace task_2
{
    class RoyalGuard: Person
    {
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
