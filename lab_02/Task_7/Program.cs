using System;

namespace Task_7
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
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > arr[s]) { l++; }
                else
                {
                    s = i;
                    l = 1;
                }
                if (bestL < l)
                {
                    bestL = l;
                    bestS = s;
                }
            }
            Console.Write($"s={bestS} l={bestL}\n");
            for (int i = bestS; i < bestL + bestS; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.ReadKey();
        }
    }
}
