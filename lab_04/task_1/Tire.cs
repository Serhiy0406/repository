﻿using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    class Tire
    {
        public int Age { get; set; }
        public double Pressure { get; set;}
        public Tire(double pressure, int age)
        {
            Age = age;
            Pressure = pressure;
        }
    }
}
