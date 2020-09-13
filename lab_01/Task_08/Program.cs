using System;

namespace Task_08
{
    class Program
    {
        static void Main(string[] args)
        {
            bool res = true;
            Console.WriteLine("Input number to check if it divided by 9, 11 or 13 without remainder");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n % 9 == 0 || n % 11 == 0 || n % 13 == 0){}
            else
            {
                res = false;
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
