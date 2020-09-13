using System;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input some integer number : ");
            int n = int.Parse(Console.ReadLine());
            int b = n % 10;
            Console.WriteLine($"Last digit is {b}");
            Console.ReadKey();
        }
    }
}
