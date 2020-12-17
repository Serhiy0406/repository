using System;
using System.Text.RegularExpressions;
namespace task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            str = Regex.Replace(str, @"<upcase>([\w\s]+)<\/upcase>",  upp=>upp.Groups[1].Value.ToUpper()/*=>
            {
                return upp.Groups[1].Value.ToUpper();
            }*/);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
