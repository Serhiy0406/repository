using System;
using System.Collections.Generic;
using System.Linq;

namespace task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Person>();
            while (true)
            {
                string[] str = Console.ReadLine().Split(' ');
                if (str[0] == "END") { break; }
                else
                {
                    students.Add(new Person(str[0]+" "+str[1], int.Parse(str[2])));
                }
            }
            var selectedStudnets = students.GroupBy(s => s.Group);
            foreach (var i in selectedStudnets)
            {
                Console.Write($"{i.Key}-");
                foreach(var item in i)
                {
                    Console.Write($"{item.Name}, ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
