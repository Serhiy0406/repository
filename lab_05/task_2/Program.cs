using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float l = float.Parse(Console.ReadLine());
            float w = float.Parse(Console.ReadLine());
            float h = float.Parse(Console.ReadLine());
            try
            {
                Box box = new Box(l, w, h);
                box.SurfaceArea();
                box.LateralSurfaceArea();
                box.Volume();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }  
            Console.ReadKey();
        }
    }
}
