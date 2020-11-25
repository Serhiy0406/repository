using System;
using System.Collections.Generic;
using System.Linq;

namespace task_08
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
                    students.Add(new Student(str[0], str[1], int.Parse(str[2]), int.Parse(str[3]), int.Parse(str[4]), int.Parse(str[5])));
                }
            }
            var selectedStudnets = students.Where(s => s.Marks.Count(el => el <= 3) >= 2);
            foreach (var i in selectedStudnets)
                Console.WriteLine($"{i.FirstName} {i.LastName}");
            Console.ReadKey();
        }
    }
}
