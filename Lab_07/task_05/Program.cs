using System;
using System.Collections.Generic;
using System.Linq;

namespace task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Society> list = new List<Society>();
            string[] info;
            do
            {
                info = Console.ReadLine().Split(' ');
                if (info.Length == 3)
                {
                    list.Add(new Citizen(info[0],int.Parse(info[1]),info[2]));
                }
                else if(info.Length == 2)
                {
                    list.Add(new Robot(info[0], info[1]));
                }
            } while (info[0]!="End");
            string part = Console.ReadLine();
            foreach (var i in list) 
            {
                if (i.Check(part))
                {
                    Console.WriteLine(i.Id);
                }
            }          
            Console.ReadKey();
        }
    }
}
