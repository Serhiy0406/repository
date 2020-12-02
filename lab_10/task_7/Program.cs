using System;
using System.Collections.Generic;
using System.Linq;
namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var setp = new SortedSet<Person>();
                var hashp = new HashSet<Person>();

                int count = int.Parse(Console.ReadLine());
                if (count < 0 || count > 100) { throw new Exception("Invalid number of persons"); }
                for (int i = 0; i < count; i++)
                {
                    string[] str = Console.ReadLine().Split(' ');
                    setp.Add(new Person(str[0], int.Parse(str[1])));
                    hashp.Add(new Person(str[0], int.Parse(str[1])));
                }
                Console.WriteLine(setp.Count);
                Console.WriteLine(hashp.Count);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
