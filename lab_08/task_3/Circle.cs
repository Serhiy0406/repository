using System;
using System.Collections.Generic;
using System.Text;

namespace task_3
{
    class Circle: Shape
    {
        public double Radius { get; protected set; }
        public Circle (double radius)
        {
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public override string Draw()
        {
            return "O";
        }
    }
}
