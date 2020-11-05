using System;
using System.Collections.Generic;
using System.Text;

namespace task_5.FoodClasses
{
    class Apple:FoodFactory
    {
        public Apple (string name)
        {
            Name = name;
            Point = 1;
        }
    }
}
