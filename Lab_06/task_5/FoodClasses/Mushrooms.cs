using System;
using System.Collections.Generic;
using System.Text;

namespace task_5.FoodClasses
{
    class Mushrooms: FoodFactory
    {
        public Mushrooms(string name)
        {
            Name = name;
            Point = -10;
        }
    }
}
