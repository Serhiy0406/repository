using System;
using System.Collections.Generic;

namespace task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Citizen> citizens = new List<Citizen>();
            while(true)
            {
                string[] s1 = Console.ReadLine().Split(' ');
                if (s1[0] == "End") { break; }
                citizens.Add(new Citizen(s1[0], s1[1], int.Parse(s1[2])));
            }
            foreach(var i in citizens)
            {
                Console.WriteLine(((IPerson)i).GetName());
                Console.WriteLine(((IREsident)i).GetName());
            }
            Console.ReadKey();
        }
    }
}
