using System;
using System.Collections.Generic;
using System.Text;

namespace task_12
{
    class Car
    {
        private string model;
        private int speed;
        public string Model { get; set; }
        public int Speed { get; set; }
        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }
    }
}
