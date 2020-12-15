using System;
using System.Globalization;

namespace task_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            Console.WriteLine(textInfo.ToTitleCase(str));

            Console.ReadKey();
        }
    }
}
