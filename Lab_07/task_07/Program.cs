using System;
using System.Collections.Generic;
using task_05;
using task_07.SocietyClasses;

namespace task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Society> list = new List<Society>();
            string[] info;
            int totalFood = 0;
            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i < number; i++)
            {
                info = Console.ReadLine().Split(' ');
                if (info.Length == 4)
                {
                    Citizen citizen = new Citizen(info[0], int.Parse(info[1]), info[2], info[3]);
                    list.Add(citizen);                    
                    citizen.BuyFood();
                }
                else if (info.Length == 3)
                {
                    Rebel rebel = new Rebel(info[0], int.Parse(info[1]), info[2]);
                    list.Add(rebel);   
                    rebel.BuyFood();
                }
            }
            string names;
            do
            {
                names = Console.ReadLine();
                if(names == "End") { break; }
                foreach(var i in list)
                {
                    if(names == i.Name)
                    {
                        totalFood += i.Food;
                        break;
                    }
                }
            } while (names != "End");

            Console.WriteLine(totalFood);
            Console.ReadKey();
        }
    }
}
