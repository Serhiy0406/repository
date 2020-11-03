using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] s1 = Console.ReadLine().Split(' ');
                string[] s2 = Console.ReadLine().Split(' ');
                Student student = new Student(s1[0], s1[1], s1[2]);
                Worker worker = new Worker(s2[0], s2[1], double.Parse(s2[2]), double.Parse(s2[3]));
                Console.WriteLine(student + Environment.NewLine);
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            Console.ReadKey();
        }
    }
}
