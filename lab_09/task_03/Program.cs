using System;
using System.Collections.Generic;
namespace task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box<string>> list = new List<Box<string>>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();
                list.Add(new Box<string>(str));
            }
            string[] num = Console.ReadLine().Split(' ');
            Swap<string>(ref list, int.Parse(num[0]), int.Parse(num[1]));
            foreach (var i in list)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadKey();
        }
        public static void Swap<T>(ref List<Box<T>> list , int a, int b)
        {
            Box<T> tmp = list[a];
            list[a] = list[b];
            list[b] = tmp;
        }
    }
}
