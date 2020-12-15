using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
namespace task_08
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word_delimiters= { ' ', ',', '!', '.', '?'};
            string str = Console.ReadLine();
            string[] words = str.Split(word_delimiters, StringSplitOptions.RemoveEmptyEntries);
            SortedSet<string> list = new SortedSet<string>();
            foreach(var i in words)
            {
                bool b = true;
                for(int j=0; j<i.Length/2; j++)
                {
                    if (i[j] != i[i.Length - 1 - j])
                        b = false;
                }
                if (b == true)
                {
                    list.Add(i);
                }
            } 
            foreach(var i  in list)
            {
                Console.Write($"{i}, ");
            }
            Console.ReadKey();
        }
    }
}
