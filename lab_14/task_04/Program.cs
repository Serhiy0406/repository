using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
namespace task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<string> letters = new List<string>();
            string keyword = Console.ReadLine();
            string sentences = Console.ReadLine();
            list = sentences.Split('.', '!', '?').ToList();
            foreach(var item in list)
            {
                letters = item.Split(' ').ToList();
                if (letters.Contains(keyword)) { Console.WriteLine(item); }
            }
            Console.ReadKey();
        }
    }
}
