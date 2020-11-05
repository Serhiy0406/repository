using System;
using System.Collections.Generic;
using System.Text;

namespace task_5.FoodClasses
{
    class Lembas: FoodFactory
    {
        public Lembas(string name)
        {
            Name = name;
            Point = 3;
        }
    }
}
