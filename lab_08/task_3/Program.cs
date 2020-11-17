using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine($"Area: {rectangle.CalculateArea()}");
            Console.WriteLine($"Perimetr: {rectangle.CalculatePerimeter()}");
            Console.WriteLine("");
            rectangle.Draw();
            Console.ReadKey();
        }
    }
}
