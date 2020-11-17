using System;
using System.Collections.Generic;
namespace task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box<int>> list = new List<Box<int>>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                int num = int.Parse(Console.ReadLine());
                list.Add(new Box<int>(num));
            }
            foreach (var i in list)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadKey();
        }
    }
}
