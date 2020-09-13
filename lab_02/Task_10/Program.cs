using System;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7];
            int c = 0;
            Console.Write("Input size of array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Input difference : ");
            int d = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n ; j++)
                { 
                    if (arr[i]+d==arr[j] || arr[i] - d == arr[j] )
                    {
                        c++;
                    }
                }
                
            }
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
