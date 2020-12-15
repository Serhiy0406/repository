using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Regex regex = new Regex(@"\b[A-Z][a-z]+\b\s\b[A-Z][a-z]+\b");
            while (true)
            {
                string str = Console.ReadLine();
                if (str == "end") { break; }
                else
                {
                    if (regex.IsMatch(str)) { list.Add(str); }
                }
            }
            foreach(string item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
