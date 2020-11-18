using System;

namespace task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Custom<string> custom = new Custom<string>();

            while (true)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (s[0] == "END") { break; }
                switch (s[0])
                {
                    case "Add":
                        custom.Add(s[1]);
                        break;
                    case "Remove":
                        custom.Remove(int.Parse(s[1]));
                        break;
                    case "Contains":
                        Console.WriteLine(custom.Contains(s[1]));
                        break;
                    case "Swap":
                        custom.Swap(int.Parse(s[1]), int.Parse(s[2]));
                        break;
                    case "Greater":
                        Console.WriteLine(custom.CountGreaterThan(s[1]));
                        break;
                    case "Max":
                        Console.WriteLine(custom.Max());
                        break;
                    case "Min":
                        Console.WriteLine(custom.Min());
                        break;
                    case "Print":
                        custom.Print();
                        break;
                }
            }
            

            Console.ReadKey();
        }
    }
}
