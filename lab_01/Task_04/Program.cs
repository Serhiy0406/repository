using System;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input upper side : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input another side : ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input heighth : ");
            double h = Convert.ToDouble(Console.ReadLine());
            double area = (a + b) / 2 * h;
            Console.WriteLine($"Area of trapezoid is {area}");
            Console.ReadKey();
        }
    }
}
