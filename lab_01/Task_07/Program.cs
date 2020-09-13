using System;

namespace Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number to compare if it greater then 20 and odd");
            bool result = true;
            int n = Convert.ToInt32(Console.ReadLine());
            if(n > 20 && n % 2 != 0)
            { 
            }
            else
            {
                result = false;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
