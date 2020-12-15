using System;
using System.Collections;
using System.Collections.Generic;
namespace task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            
            char[] tmp = str.ToCharArray();
            string reverse = String.Empty;
            for (int i = tmp.Length - 1; i > -1; i--)
            {
                reverse += tmp[i];
            }
            Console.WriteLine(reverse);
            Console.ReadKey();
        }
    }
}
