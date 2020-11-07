using System;
using System.Collections.Generic;
using task_05;

namespace task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Citizen> list = new List<Citizen>();
            List<Robot> robotlist = new List<Robot>();
            List<Pet> petlist = new List<Pet>();
            string[] info;
            do
            {
                info = Console.ReadLine().Split(' ');
                if (info[0] == "End") { break; }               
                string caseSwitch = info[0];
                switch (caseSwitch)
                {
                    case "Citizen":
                        list.Add(new Citizen(info[1], int.Parse(info[2]), info[3], info[4]));
                        break;
                    case "Pet":
                        petlist.Add(new Pet(info[1],info[2]));
                        break;
                    case "Robot":
                        robotlist.Add(new Robot(info[1], info[2]));
                        break;
                }
            } while (info[0] != "End");
            string part = Console.ReadLine();
            foreach (var i in list)
            {
                if (i.Check(part))
                {
                    Console.WriteLine(i.Birthdate);
                }
            }
            foreach (var i in petlist)
            {
                if (i.Check(part))
                {
                    Console.WriteLine(i.Birthdate);
                }
            }
            Console.ReadKey();
        }
    }
}
