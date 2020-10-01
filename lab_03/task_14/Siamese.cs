using System;
using System.Collections.Generic;
using System.Text;

namespace task_14
{
    class Siamese : Cat
    {
        public string Type { get; set; }
        public int EarSize { get; set; }
        public override void PrintOut()
        {
            
            Console.WriteLine($"{Type} {Name} {EarSize}");
        }
        public Siamese(string type, string name, int earsize)
            : base(name)
        {
            Type = type;
            EarSize = earsize;
        }
    }
}
