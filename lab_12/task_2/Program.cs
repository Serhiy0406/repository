using System;
using System.Collections.Generic;
using System.Linq;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            King king = new King(Console.ReadLine());
            string[] str = Console.ReadLine().Split(' ');
            foreach(var item in str)
            {
                people.Add(new RoyalGuard(item));
            }
            string[] str1 = Console.ReadLine().Split(' ');
            foreach(var item in str1)
            {
                people.Add(new Footman(item));
            }

            foreach(var item in people)
            {
                king.Attacked += item.KingIsAttacked;
            }

            while (true)
            {
                string[] info = Console.ReadLine().Split(' ');
                if (info[0] == "End") { break; }
                if (info[0] == "Attack") { king.StartAttack(); }
                else
                {
                    var x = people.Find(element => element.Name == info[1]);
                    king.Attacked -= x.KingIsAttacked;
                    people.Remove(x);
                }
            }

            Console.ReadKey();
        }
    }
}
