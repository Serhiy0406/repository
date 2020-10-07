using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxi galaxi = new Galaxi();
            string[] s1 = Console.ReadLine().Split(' ');
            int n = int.Parse(s1[0]);
            int m = int.Parse(s1[1]);
            galaxi.Input(n, m);
            int count = 0;
            for(int i = 0; i < 100; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (s[0] == "Let")
                    break;
                else
                {
                    if(count == 0)
                    {
                        galaxi.IvoAdd(int.Parse(s[0])-1, int.Parse(s[1]) + 1);
                        count++;
                    }
                    if(count == 1)
                    {
                        
                        galaxi.EvilAdd(int.Parse(s[0])-1, int.Parse(s[1])-1);
                        count--;
                    }
                }

            }
            galaxi.Check();
            int suma = galaxi.Suma();
            Console.WriteLine($"\n{suma}");
            Console.ReadKey();
        }
    }
}
