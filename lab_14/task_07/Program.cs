using System;
using System.Text.RegularExpressions;
namespace task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            while(Regex.IsMatch(str, @"<upcase>([\w\s]+)<\/upcase>"))
            {
                str = Regex.Replace(str, @"<upcase>([\w\s]+)<\/upcase>", upp=>
                {
                    return upp.Groups[1].Value.ToUpper();
                });
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
