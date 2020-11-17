using System;
using System.Collections.Generic;
namespace task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = new List<double>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                double str = double.Parse(Console.ReadLine());
                list.Add(str);
            }
            double element = double.Parse(Console.ReadLine());
            Console.WriteLine(CountMethod<double>(ref list, element));
            Console.ReadKey();
        }
        public static int CountMethod<T>(ref List<T> list, T element)
        {
            int count = 0;
            foreach (var i in list)
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
