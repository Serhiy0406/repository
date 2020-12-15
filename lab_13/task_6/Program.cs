using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            string keyword = Console.ReadLine();
            string sentences;
            Regex regex = new Regex(@$"[A-Z].+\b{keyword}.+(\.|\?|!)");
            while (true)
            {
                sentences = Console.ReadLine();
                if (sentences == "") { break; }
                else
                {
                    if (regex.IsMatch(sentences)) { list.Add(sentences); }
                }
            }
            Console.WriteLine($"Result: {list.Count}");

            foreach (string item in list)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
