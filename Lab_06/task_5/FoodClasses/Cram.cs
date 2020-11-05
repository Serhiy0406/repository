using System;
using System.Collections.Generic;
using System.Text;

namespace task_5.FoodClasses
{
    class Cram: FoodFactory
    {
        public Cram(string name)
        {
            Name = name;
            Point = 2;
        }
    }
}
