using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> list = new List<string>();
                string str = Console.ReadLine();
                if (str.Length > 9999)
                    throw new Exception("The input line must hold characters in the range [0 … 9999]");
                string[] names = str.Split(' ', '(', ')', '/', '\\');
                Regex regex = new Regex(@"^[a-zA-z]\w{3,25}");
                foreach (var item in names)
                    if (regex.IsMatch(item))
                    {
                        list.Add(item);
                    }
                string firstname = "";
                string secondname = "";
                int max = 0;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i].Length + list[i + 1].Length > max)
                    {
                        max = list[i].Length + list[i + 1].Length;
                        firstname = list[i];
                        secondname = list[i + 1];
                    }
                }
                Console.WriteLine($"{firstname}\n{secondname}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadKey();    
        }
    }
}
