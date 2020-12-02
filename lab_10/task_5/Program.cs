using System;
using System.Collections.Generic;
using System.Linq;
namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Person> persons = new List<Person>();

                while (true)
                {
                    string[] str = Console.ReadLine().Split(' ');
                    if (str[0] == "END") break;
                    persons.Add(new Person(str[0], int.Parse(str[1]), str[2]));
                }
                int index = int.Parse(Console.ReadLine()) - 1;
                int others;
                int equalsp = persons.Count(i => i.CompareTo(persons[index]) == 0);
                if (equalsp == 1) { throw new Exception("No matches"); }
                else
                {
                    others = persons.Count - equalsp;
                    Console.WriteLine($"{equalsp} {others} {persons.Count}");
                }        
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
