using System;

namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            double nDigit = Math.Floor(number / Math.Pow(10, (n - 1))) % 10;
            if (nDigit == 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine(nDigit);
            }
            Console.ReadKey();
        }
    }
}
