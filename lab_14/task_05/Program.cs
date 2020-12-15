using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
namespace task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string str1 = str, str2 = str;
            string protocol = "", server = "", resource = "";
            protocol = Regex.Replace(str, @"(.+):\/\/(www[a-z.]+)\/(.+)", "$1");
            server = Regex.Replace(str1, @"(.+):\/\/(www[a-z.]+)\/(.+)", "$2");
            resource = Regex.Replace(str2, @"(.+):\/\/(www[a-z.]+)\/(.+)", "$3");
            Console.WriteLine($"[protocol] = '{protocol}' ");
            Console.WriteLine($"[server] = '{server}' ");
            Console.WriteLine($"[resource] = '{resource}' ");
            Console.ReadKey() ;
        }
    }
}
