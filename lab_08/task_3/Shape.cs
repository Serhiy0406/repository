using System;
using System.Collections.Generic;
using System.Text;

namespace task_3
{
    abstract class Shape
    {
        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();
        public virtual string Draw()
        {
            return "";
        }
    }
}
