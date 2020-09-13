using System;

namespace Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int f=1;
            for(int i=0; i<n; i++)
            {
                f *= n - i;
            }
            Console.WriteLine($"Factorial : {f}");
            Console.ReadKey();
        }
    }
}
