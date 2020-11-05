using System;
using System.Collections.Generic;
using System.Text;

namespace task_5.FoodClasses
{
    class HoneyCake: FoodFactory
    {
        public HoneyCake(string name)
        {
            Name = name;
            Point = 5;
        }
    }
}
