using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Custom<string> a = new Custom<string>();
                List<string> b = new List<string>();
                string[] str;
                do
                {
                    str = Console.ReadLine().Split(" ");
                    string switchcase = str[0];
                    switch (switchcase)
                    {
                        case "END":
                            break;
                        case "Push":
                            b = str.ToList();
                            b.Remove("Push");
                            a.Push(b);
                            break;
                        case "Pop":
                            a.Pop();
                            break;
                        default:
                            throw new Exception("Invalid comand");
                    }
                } while (str[0] != "END");
                for (int i = 0; i < 2; i++)
                {
                    foreach (var item in a)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            
            Console.ReadKey();
        }
    }
}
