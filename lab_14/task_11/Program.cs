using System;
using System.Linq;
namespace task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            bool b = false;
            foreach(var i in str1)
            {
                if (str2.Contains(i))
                {
                    b = true;
                    break;
                }
            }
            Console.WriteLine(b ? "YES" : "NO");
            Console.ReadKey();
        }
    }
}
