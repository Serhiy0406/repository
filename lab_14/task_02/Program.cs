using System;
using System.Linq;
namespace task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            str = (str.Length > 20) ? str.Substring(0, 20) : str.PadRight(20, '*');
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
