using System;
using System.Collections.Generic;
using System.Linq;

namespace task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var companies = new List<Company>();
                int count = int.Parse(Console.ReadLine());
                if(count>=1 && count <= 100)
                {
                    for(int i=0;i<count; i++)
                    {
                        string[] str = Console.ReadLine().Split(" - ");
                        companies.Add(new Company(str[0], int.Parse(str[1]), str[2]));
                    }
                    Console.WriteLine("");
                    var result = companies.GroupBy(c => c.Name).OrderBy(c => c.Key);
                    foreach(var i in result)
                    {
                        Console.Write($"{i.Key}: ");
                        foreach(var item in i)
                        {
                            Console.Write($"{item.Product}-{item.Amount}, ");
                        }
                        Console.WriteLine("");
                    }
                }
                else
                {
                    throw new Exception("Value of count should be between [1 .. 100]");
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
