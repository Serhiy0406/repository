using System;
using System.Collections.Generic;
using System.Linq;

namespace task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            while (true)
            {
                string[] str = Console.ReadLine().Split(' ');
                if (str[0] == "END") { break; }
                else
                {
                    students.Add(new Student(str[0], str[1], str[2]));
                }
            }
            var selectedStudnets = students.Where(s => s.Phone.StartsWith("02") || s.Phone.StartsWith("+3592"));
            foreach (var i in selectedStudnets)
                Console.WriteLine($"{i.FirstName} {i.LastName}");
            Console.ReadKey();
        }
    }
}
