using System;
using System.Collections.Generic;
using System.Text;

namespace task_2
{
    class Box
    {
        private float length;
        private float width;
        private float height;
        public float Length {
            get { return length; }
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Length cannot be zero or negative.");
                }
                else
                {
                    length = value;
                }
            }
        }
        public float Width {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Width cannot be zero or negative.");
                }
                else
                {
                    width = value;
                }
            }
        }
        public float Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Height cannot be zero or negative.");
                }
                else
                {
                    height = value;
                }
            }
        }

        public Box(float l, float w, float h)
        {
            Length = l;
            Width = w;
            Height = h;
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
