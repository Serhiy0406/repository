using System;
using System.Collections.Generic;
using System.Text;

namespace task_3
{
    class Rectangle: Shape
    {
        public double Heigth { get; protected set; }
        public double Width { get; protected set; }
        public Rectangle (double heigth, double width)
        {
            Heigth = heigth;
            Width = width;
        }
        public override double CalculateArea()
        {
            return Heigth * Width;
        }
        public override double CalculatePerimeter()
        {
            return 2 * (Heigth + Width);
        }
        public override string Draw()
        {
            for(int i = 0; i < Heigth; i++)
            {
                for(int j = 0; j < Width; j++)
                {
                    if(i==0 || i == Heigth - 1)
                    {
                        Console.Write("-");
                    }else if(j == 0 || j == Width - 1)
                    {
                        Console.Write("|");
                    }
                    else { Console.Write(" "); }
                }
                Console.WriteLine("");
            }
            return base.Draw();
        }
    }
}
