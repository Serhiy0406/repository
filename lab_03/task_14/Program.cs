using System;
using System.Collections.Generic;

namespace task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cat> cats = new List<Cat>();
            for(int i = 0; i < 20; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (s[0] == "End")
                {
                    break;
                }
                else
                {
                    if (s[0] == "Siamese")
                    {
                        cats.Add(new Siamese(s[0], s[1], int.Parse(s[2])));
                    }
                    if (s[0] == "Cymric")
                    {
                        cats.Add(new Cymric(s[0], s[1], float.Parse(s[2])));
                    }
                    if (s[0] == "StreetExtraordinaire")
                    {
                        cats.Add(new StreetExtraordinaire(s[0], s[1], int.Parse(s[2])));
                    }
                }               
            }
            string a = Console.ReadLine();
            for(int i = 0; i < cats.Count; i++)
            {
                if (cats[i].Name == a)
                {
                    cats[i].PrintOut();
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
