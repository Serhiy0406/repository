using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(", ");
            List<int> rocks = new List<int>();
            foreach (var i in str)
                rocks.Add(int.Parse(i));

            var lake = new Lake(rocks);

            foreach (var i in lake)
            {
                Console.Write($"{i} ");
            }

            Console.ReadKey();
        }
    }
}
