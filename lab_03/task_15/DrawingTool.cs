using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace task_15
{
    class DrawingTool: Square
    {
        public int Horizontal { get; set; }
        public int Vertical { get; set; }

        public DrawingTool(int a, int b)
        {
            Horizontal = a;
            Vertical = b;
        }
        public override void Draw()
        {
            for (int i = 0; i < Vertical; i++)
            {
                Console.Write("|");
                for (int j = 0; j < Horizontal; j++)
                {
                    if (i == 0 || i == Vertical - 1)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("|\n");
            }
        }
    }
}
