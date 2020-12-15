using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string badString = Console.ReadLine();
            string CleanedString = Regex.Replace(badString, @"(.)\1+", "$1");
            Console.WriteLine($"Cleaned String: {CleanedString}");
            Console.ReadKey();
        }
    }
}
