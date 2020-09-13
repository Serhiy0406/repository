using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[15];
            int s = 0;
            int l = 1;
            int bestS = -1;
            int bestL = -1;
            Console.Write("Input size of array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j]) { l++; }
                    if (bestL < l)
                    {
                        bestL = l;
                        bestS = s;
                    }
                }
                s = i;
                l = 1;
            }
            Console.Write($"s={bestS} l={bestL}\n");
            Console.Write($"number is {arr[bestS]}");
            Console.ReadKey();
        }
    }
}
