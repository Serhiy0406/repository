using System;
using System.Collections.Generic;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            try
            {
                string[] s = Console.ReadLine().Split(';');
                for (int i = 0; i < s.Length; i++)
                {
                    string[] s1 = s[i].Split('=');
                    people.Add(new Person(s1[0], int.Parse(s1[1])));
                }
                string[] p = Console.ReadLine().Split(';');
                for (int i = 0; i < p.Length; i++)
                {
                    string[] p1 = p[i].Split('=');
                    products.Add(new Product(p1[0], int.Parse(p1[1])));
                }
                for (int i = 0; i < 10; i++)
                {
                    string[] r = Console.ReadLine().Split(' ');
                    if (r[0] == "END")
                    {
                        break;
                    }
                    else
                    {
                        for (int j = 0; j < people.Count; j++)
                        {
                            if (people[j].Name == r[0])
                            {
                                for (int k = 0; k < products.Count; k++)
                                {
                                    if (products[k].Name == r[1])
                                    {
                                        people[j].Check(products[k].Name, products[k].Cost);
                                        break;
                                    }
                                }
                                break;
                            }
                        }
                    }
                }
                for (int i = 0; i < people.Count; i++)
                {
                    people[i].Output();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            
            Console.ReadKey();
        }
    }
}
