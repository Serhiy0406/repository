using System;
using System.Collections.Generic;
using System.Text;

namespace task_2
{
    class Car
    {
        public string Model { get; set; }
        public string Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }
        public Car(string model, string engine, int weight = 0, string color = "n/a")
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }
    }
}
