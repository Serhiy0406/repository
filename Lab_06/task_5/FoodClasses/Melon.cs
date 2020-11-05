using System;
using System.Collections.Generic;
using System.Text;

namespace task_5.FoodClasses
{
    class Melon: FoodFactory
    {
        public Melon(string name)
        {
            Name = name;
            Point = 1;
        }
    }
}
