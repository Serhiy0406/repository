using System;

namespace task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            if (s1 == "Square")
            {
                int a = Convert.ToInt32(Console.ReadLine());
                DrawingTool figure = new DrawingTool(a, a);
                figure.Draw();
            }
            else
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                DrawingTool figure = new DrawingTool(a, b);
                figure.Draw();
            }
        }
    }
}
