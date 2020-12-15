using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Regex regex = new Regex(@"^[^-_.][A-Za-z]+(.|_|-)?[A-Za-z]+@[A-Za-z]+(.|-)?[A-Za-z]\.[A-Za-z]+");
            MatchCollection matches = regex.Matches(str);
            foreach (var item in matches)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
