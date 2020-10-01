using System;
using System.Collections.Generic;
using System.Text;

namespace task_14
{
    class Cymric : Cat
    {
        string type;
        float furlength;
        public string Type { get; set; }
        public float FurLength { get; set; }

        public override void PrintOut()
        {
            
            Console.WriteLine($"{Type} {Name} {FurLength:0.00}");
        }
        public Cymric(string type,string name, float furlength)
            : base (name)
        {
            Type = type;
            FurLength = furlength;
        }
    }
}
