using System;
using System.Collections.Generic;
namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Final final = new Final();
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                if(s.Length==4)
                    final.engines.Add(new Engine(s[0], int.Parse(s[1]), int.Parse(s[2]), s[3]));
                if (s.Length == 3)
                {
                    if (s[2][0] <= 'A')
                        final.engines.Add(new Engine(s[0], int.Parse(s[1]), int.Parse(s[2])));
                    if (s[2][0] >= 'A')
                        final.engines.Add(new Engine(s[0], int.Parse(s[1]), 0 ,s[2]));
                }                   
                if (s.Length == 2)
                    final.engines.Add(new Engine(s[0], int.Parse(s[1])));
            }
            int m = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (s.Length == 4)
                    final.cars.Add(new Car(s[0], s[1], int.Parse(s[2]), s[3]));
                if (s.Length == 3)
                {
                    if(s[2][0] <= 'A')
                    final.cars.Add(new Car(s[0], s[1], int.Parse(s[2])));
                    if(s[2][0] >= 'A')
                    final.cars.Add(new Car(s[0], s[1], 0 ,s[2]));
                }
                if (s.Length == 2)
                    final.cars.Add(new Car(s[0], s[1]));

            }
            final.printOut();
            Console.ReadKey();
        }
    }
}
