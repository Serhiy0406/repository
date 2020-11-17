using System;
using System.Collections.Generic;
namespace task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box<string>> list = new List<Box<string>>();
            int count = int.Parse(Console.ReadLine());
            for(int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();
                list.Add(new Box<string>(str));
            }
            foreach(var i in list)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadKey();
        }
    }
}
