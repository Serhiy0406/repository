using System;
using System.Collections.Generic;
namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxi galaxi = new Galaxi();
            Ivo ivo = new Ivo();
            Evil evil = new Evil();
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]);
            int m = int.Parse(s[1]);
            galaxi.Input(n, m);
            for(int i = 0; i < 100; i++)
            {
                string[] s1 = Console.ReadLine().Split(' ');
                if (s1[0] == "Let")
                    break;
                else
                {
                    ivo.row = int.Parse(s1[0])-1;
                    ivo.col = int.Parse(s1[1])+1;
                    ivo.AddElements(galaxi);
                    string[] s2 = Console.ReadLine().Split(' ');
                    evil.row = int.Parse(s2[0])-1;
                    evil.col = int.Parse(s2[1])-1;
                    evil.AddElements(galaxi);
                    
                }
            }
            Galaxi.Compare(ivo, evil);
            Console.WriteLine($"{ivo.Suma}");
            Console.ReadKey();
        }
    }
}
