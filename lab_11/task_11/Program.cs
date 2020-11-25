using System;
using System.Collections.Generic;
using System.Linq;

namespace task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            var specialities = new List<Specialty>();
            while (true)
            {
                string[] str = Console.ReadLine().Split(' ');
                if (str[0] == "Students:") { break; }
                else
                {
                    specialities.Add(new Specialty(str[0] + " " + str[1], int.Parse(str[2])));
                }
            }
            while (true)
            {
                string[] str = Console.ReadLine().Split(' ');
                if (str[0] == "END") { break; }
                else
                {
                    students.Add(new Student( int.Parse(str[0]), str[1], str[2]));
                }
            }
            var result = students.Join(specialities, st => st.Number, sp => sp.Number,
                (st, sp) => new { Names = st.FirstName + " " + st.LastName, Num = st.Number, Spec = sp.Name }).OrderBy(s=> s.Names);

            foreach (var i in result)
            {
                Console.WriteLine($"{i.Names} {i.Num} {i.Spec}");
            }
            Console.ReadKey();
        }
    }
}
