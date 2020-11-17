using System;
using System.Collections.Generic;
namespace task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box<int>> list = new List<Box<int>>();
            int count = int.Parse(Console.ReadLine());
            for(int i = 0; i < count; i++)
            {
                int num = int.Parse(Console.ReadLine());
                list.Add(new Box<int>(num));
            }
            string[] arr = Console.ReadLine().Split(' ');
            Swap<int>(ref list, int.Parse(arr[0]), int.Parse(arr[1]));
            foreach(var i in list)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadKey();
        }
        public static void Swap<T>(ref List<Box<T>> list, int a, int b)
        {
            Box<T> tmp = list[a];
            list[a] = list[b];
            list[b] = tmp;
        }
    }
}
