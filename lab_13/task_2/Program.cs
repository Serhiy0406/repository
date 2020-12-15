using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Regex regex = new Regex(@"^[+](359)(\s|-)2\2\d{3}\2\d{4}\b");
            while (true)
            {
                string str = Console.ReadLine();
                if (str == "end") { break; }
                else
                {
                    if (regex.IsMatch(str)) { list.Add(str); }
                }
            }
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
