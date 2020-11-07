using System;

namespace task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string driver_name = Console.ReadLine();
            Ferrari ferrari = new Ferrari(driver_name);
            Console.WriteLine($"{ferrari.Model}/{ferrari.Break()}/{ferrari.Gas()}/{ferrari.Driver}");
            Console.ReadKey();
        }
    }
}
