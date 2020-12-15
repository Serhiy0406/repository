using System;
using System.Collections.Generic;
namespace task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string[] str;
            while (true)
            {
                str = Console.ReadLine().Split(' ');
                if (str[0] == "END") { break; }
                if(str[0] == "A")
                {
                    phonebook[str[1]] = str[2];
                }
                else if(str[0]=="S")
                {
                    if (phonebook.ContainsKey(str[1]))
                    {
                        Console.WriteLine($"{str[1]} --> {phonebook[str[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {str[1]} does not exist.");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
