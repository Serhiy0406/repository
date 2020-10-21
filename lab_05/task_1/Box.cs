using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    class Box
    {
        private float length;
        private float width;
        private float height;
        public Box (float l , float w , float h)
        {
            length = l;
            width = w;
            height = h;
        }
        public void SurfaceArea()
        {
            float result = 2 * length * width + 2 * length * height + 2 * width * height;
            Console.WriteLine($"Surface Area - {result:0.00}");
        }
        public void LateralSurfaceArea()
        {
            float result = 2 * length * height + 2 * width * height;
            Console.WriteLine($"Lateral Surface Area- {result:0.00}");
        }
        public void Volume()
        {
            float result = length * width * height;
            Console.WriteLine($"Volume - {result:0.00}");
        }
    }
}
