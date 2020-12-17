using System;
using System.Globalization;

namespace task_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            //Creates a TextInfo based on the "en-US" culture
            //CultureInfo - Initializes a new instance based on the culture specified by name 
            //and Boolean that specifies whether to use the user-selected culture setting from the system
            TextInfo textInfo = new CultureInfo("en-US", true).TextInfo;
            Console.WriteLine(textInfo.ToTitleCase(str));
            //The string is converted to title case by using the conventions of the en-US culture
            Console.ReadKey();
        }
    }
}
