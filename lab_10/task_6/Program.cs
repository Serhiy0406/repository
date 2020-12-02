using System;
using System.Collections.Generic;
namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var setforname = new SortedSet<Person>(new NameSort());
                var setforage = new SortedSet<Person>(new AgeSort());

                int count = int.Parse(Console.ReadLine());
                if(count < 0 || count > 100) { throw new Exception("Invalid number of persons"); }
                for (int i = 0; i < count; i++)
                {
                    string[] str = Console.ReadLine().Split(' ');
                    setforage.Add(new Person(str[0], int.Parse(str[1])));
                    setforname.Add(new Person(str[0], int.Parse(str[1])));
                }
                foreach (var i in setforname)
                    Console.WriteLine(i);
                foreach (var i in setforage)
                    Console.WriteLine(i);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
