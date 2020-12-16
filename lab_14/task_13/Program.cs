using System;
using System.Collections.Generic;

namespace task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            while (true)
            {
                string[] str = Console.ReadLine().Split(' ');
                if (str[0] == "END") { break; }
                if (str[0] == "ListAll")
                {
                    foreach (var i in phonebook)
                        Console.WriteLine($"{i.Key} --> {i.Value}");
                    break;
                }
                if (str[0] == "A")
                {
                    phonebook[str[1]] = str[2];
                }
                else if(str[0]=="S")
                {
                    Console.WriteLine($"{str[1]} --> {phonebook[str[1]]}");
                }
            }
            Console.ReadKey();
        }
    }
}
