using System;

namespace task_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection1 collection1 = new Collection1();
            Collection2 collection2 = new Collection2();
            Collection3 collection3 = new Collection3();
            string[] s = Console.ReadLine().Split(' ');
            int count = int.Parse(Console.ReadLine());
            for(int i = 0; i < s.Length; i++)
            {
                Console.Write($"{collection1.Add(s[i])} ");
            }
            Console.WriteLine("");
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write($"{collection2.Add(s[i])} ");
            }
            Console.WriteLine("");
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write($"{collection3.Add(s[i])} ");
            }
            Console.WriteLine("");
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{collection2.Remove()} ");
            }
            Console.WriteLine("");
            for (int i = 0; i <count; i++)
            {
                Console.Write($"{collection3.Remove()} ");
            }
            Console.ReadKey();
        }
    }
}
