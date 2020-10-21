using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            try
            {
                Chicken chicken = new Chicken(n, a);
                chicken.Output();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
