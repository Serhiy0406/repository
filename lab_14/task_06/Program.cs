using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
namespace task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Match[] letters = Regex.Matches(str, @"\w+").ToArray();
            var separators = Regex.Matches(str,@"\W+");
            letters = letters.Reverse().ToArray();
            for (int i=0; i < letters.Length; i++)
            {
                Console.Write($"{letters[i]}{separators[i]}");
            }
            Console.ReadKey();
        }
    }
}
