using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Pet> pets = new List<Pet>();
                List<Clinic> clinics = new List<Clinic>();
                int count = int.Parse(Console.ReadLine());
                if (count < 0 || count > 100) { throw new Exception("Invalid number of persons"); }
                for (int i = 0; i < count; i++)
                {
                    string[] str = Console.ReadLine().Split(' ');
                    string caseSwitch = str[0];
                    switch (caseSwitch)
                    {

                        case "Create":
                            if (str[1] == "Pet")
                                pets.Add(new Pet(str[2], int.Parse(str[3]), str[4]));
                            if (str[1] == "Clinic")
                                clinics.Add(new Clinic(str[2], int.Parse(str[3])));
                            break;
                        case "Add":
                            foreach (var item in clinics)
                                if (item.Name == str[2])
                                {
                                    foreach (var it in pets)
                                        if (it.Name == str[1])
                                        {
                                            Console.WriteLine(item.Add(it));
                                            break;
                                        }
                                    break;
                                }
                            break;
                        case "Release":
                            foreach (var item in clinics)
                                if (item.Name == str[1])
                                {
                                    Console.WriteLine(item.Release());
                                    break;
                                }
                            break;
                        case "HasEmptyRooms":
                            foreach (var item in clinics)
                                if (item.Name == str[1])
                                {
                                    Console.WriteLine(item.HasEmptyRooms());
                                    break;
                                }
                            break;
                        case "Print":
                            if (str[2] != null)
                            {
                                foreach (var item in clinics)
                                    if (item.Name == str[1])
                                    {
                                        item.Print(int.Parse(str[2]));
                                        break;
                                    }
                            }
                            else
                            {
                                foreach (var item in clinics)
                                    if (item.Name == str[1])
                                    {
                                        item.Print();
                                        break;
                                    }
                            }

                            break;
                    }
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
