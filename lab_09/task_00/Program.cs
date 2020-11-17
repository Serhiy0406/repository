using System;

namespace task_00
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<int> box1 = new Box<int>(int.Parse(Console.ReadLine()));
            Console.WriteLine(box1.ToString());
            Box<string> box2 = new Box<string>(Console.ReadLine());
            Console.WriteLine(box2.ToString());
            Console.ReadKey();
        }
    }
}
