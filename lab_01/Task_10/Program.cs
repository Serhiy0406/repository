using System;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            int n = 0;
            if (a < 0) { n += 1; }
            if (b < 0) { n += 1; }
            if (c < 0) { n += 1; }
            if (n==2 || n == 0) { Console.WriteLine("Positive"); }
            else { Console.WriteLine("Negative"); }
            Console.ReadKey();
        }
    }
}
