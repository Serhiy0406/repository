using System;
using System.Collections.Generic;
using System.Text;

namespace task_14
{
    class StreetExtraordinaire : Cat
    {
        string type;
        int decibelsOfMeows;
        public string Type { get; set; }
        public int DecibelsOfMeows { get; set; }

        public override void PrintOut()
        {
            
            Console.WriteLine($"{Type} {Name} {DecibelsOfMeows}");
        }
        public StreetExtraordinaire(string type, string name, int decibe)
            : base (name)
        {
            Type = type;
            DecibelsOfMeows = decibe;
        }
    }
}
