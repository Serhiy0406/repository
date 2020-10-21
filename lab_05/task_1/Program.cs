using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float l = float.Parse(Console.ReadLine());
            float w = float.Parse(Console.ReadLine());
            float h = float.Parse(Console.ReadLine());
            Box box = new Box(l, w, h);
            box.SurfaceArea();
            box.LateralSurfaceArea();
            box.Volume();
            Console.ReadKey();
        }
    }
}
