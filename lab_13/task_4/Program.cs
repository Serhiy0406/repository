using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string info = "";
            while (true)
            {
                string str = Console.ReadLine();
                if (str == "end") { break; }
                else {
                    if(str.Contains("<a")){
                        string CleanedString = Regex.Replace(str, @"\B(<a)", "[R");
                        info += CleanedString + "\n";
                    }
                    else if (str.EndsWith("</a>"))
                    {
                        string CleanedString = Regex.Replace(str, @"</a>", "[/URL]");
                        info += CleanedString + "\n";
                    }                 
                    else info += str+"\n";
                }
            }
            Console.WriteLine($"{info}");
            Console.ReadKey();
        }
    }
}
