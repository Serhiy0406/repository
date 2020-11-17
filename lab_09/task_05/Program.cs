using System;
using System.Collections.Generic;
namespace task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();
                list.Add(str);
            }
            string element = Console.ReadLine();
            Console.WriteLine(CountMethod<string>(ref list, element));
            Console.ReadKey();
        }
        public static int CountMethod<T>(ref List<T> list, T element)
        {
            int count = 0;
            foreach(var i in list)
            {
                if (Comparer<T>.Default.Compare(i, element) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
