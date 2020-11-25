using System;
using System.Collections.Generic;
using System.Linq;

namespace task_09
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
                    students.Add(new Student(str[0], int.Parse(str[1]), int.Parse(str[2]), int.Parse(str[3]), int.Parse(str[4])));
                }
            }
            var selectedStudnets = students.Where
                (
                    s => s.FacultyNumber.Substring(4,2)=="14" ||
                    s.FacultyNumber.Substring(4, 2) == "15"
                );
            foreach (var i in selectedStudnets)
                Console.WriteLine(string.Join(' ', i.Marks));
            Console.ReadKey();
        }
    }
}
