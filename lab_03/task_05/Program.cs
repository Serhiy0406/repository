using System;

namespace task_05
{
    class Program
    {
        class DateModifier 
        {
            static public void GetDifference(string a, string b)
            {
                DateTime a1 = DateTime.Parse(a);
                DateTime b1 = DateTime.Parse(b);
                int result = DateTime.Compare(a1, b1);
                if (result < 0) { Console.WriteLine(b1.Subtract(a1).Days); }
                else { Console.WriteLine(a1.Subtract(b1).Days); }
            }
        }

        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            DateModifier.GetDifference(a, b);
            Console.ReadKey();
        }
    }
}
