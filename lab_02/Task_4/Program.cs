using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] arr = new bool[1000];
            Console.Write("Input n : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= n; i++)
            {
                arr[i] = true;
            }
            arr[0] = arr[1] = false;
            for(int i=0; i <= n; i++)
            {
                if (arr[i] == true)
                {
                    Console.Write($"{i} ");
                    for (int j = 2; j <= n/2; j++)
                    {
                        arr[i * j] = false;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
