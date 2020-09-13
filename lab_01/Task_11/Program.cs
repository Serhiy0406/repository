using System;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number : ");
            double n = Convert.ToDouble(Console.ReadLine());
            switch (n)
            {
                case 1: Console.WriteLine("Monday");break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Thersday"); break;
                case 4: Console.WriteLine("Thursday"); break;
                case 5: Console.WriteLine("Friday"); break;
                case 6: Console.WriteLine("Saturday"); break;
                case 7: Console.WriteLine("Sunday"); break;
                default: Console.WriteLine("Not valid"); break;
            }
            Console.ReadKey();
        }
    }
}
