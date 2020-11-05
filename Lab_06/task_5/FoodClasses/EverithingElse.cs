using System;
using System.Collections.Generic;
using System.Text;

namespace task_5.FoodClasses
{
    class EverithingElse: FoodFactory
    {
        public EverithingElse(string name)
        {
            Name = name;
            Point = -1;
        }
    }
}
