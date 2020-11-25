using System;
using System.Collections.Generic;
using System.Linq;

namespace task_03
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
                    students.Add(new Student(str[0], str[1], int.Parse(str[2])));
                }
            }
            var selectedStudnets = students.Where(s => s.Age >= 18 && s.Age <= 24);
            foreach (var i in selectedStudnets)
                Console.WriteLine($"{i.FirstName} {i.LastName} {i.Age}");
            Console.ReadKey();
        }
    }
}
