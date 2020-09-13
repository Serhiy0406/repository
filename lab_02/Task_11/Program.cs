using System;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[12];
            int c = 1,sum1=0,sum2=0;
            Console.Write("Input size of array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            while (c <=n-1)
            {
                for (int j = 0; j < c; j++)
                {
                    sum1 += arr[j];
                }
                for (int i = c+1 ; i < n; i++)
                {
                    sum2 += arr[i];
                }
                if (sum1 == sum2)
                {
                    Console.WriteLine(c);
                    break;
                }
                else
                {
                    sum1 = 0;
                    sum2 = 0;
                }
                
                c++;
            }
            if (c == 0 || n==2)
            {
                Console.WriteLine("no");
            }
            else
            {
                if (n == 1)
                {
                    Console.WriteLine(0);
                }
            }
            
            Console.ReadKey();
        }
    }
}
