using System;
using System.Collections.Generic;
using System.Text;

namespace task_2
{
    class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }
        public Engine(string model, int power, int displacement = 0, string efficiency = "n/a")
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }
    }
}
