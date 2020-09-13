using System;

namespace Task_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 3 numbers to find bigger one");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c) { Console.WriteLine($"number {a} is bigger one"); }
            else if (b > a && b > c) { Console.WriteLine($"number {b} is bigger one"); }
            else { Console.WriteLine($"number {c} is bigger one"); }
            Console.ReadKey();
        }
    }
}
