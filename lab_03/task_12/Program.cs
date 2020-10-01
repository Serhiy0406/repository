using System;
using System.Collections.Generic;
namespace task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            Company company;
            Pokemon pokemon;
            Parents parents;
            Children children;
            Car car;
            bool b;
            for(int i = 0; i < 100; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (s[0] == "End")
                {
                    break;
                }
                else
                {
                    b = false;
                    for(int j = 0; j < people.Count; j++)
                    {
                        if (people[j].Name == s[0])
                        {
                            if (s[1] == "company")
                            {
                                company = new Company(s[2],s[3],float.Parse(s[4]));
                                people[j].AddInformation(company);
                                b = true;
                                break;
                            }
                            if (s[1] == "pokemon")
                            {
                                pokemon = new Pokemon(s[2], s[3]);
                                people[j].AddInformation(pokemon);
                                b = true;
                                break;
                            }
                            if (s[1] == "parents")
                            {
                                parents = new Parents(s[2], s[3]);
                                people[j].AddInformation(parents);
                                b = true;
                                break;
                            }
                            if (s[1] == "children")
                            {
                                children = new Children(s[2], s[3]);
                                people[j].AddInformation(children);
                                b = true;
                                break;
                            }
                            if (s[1] == "car")
                            {
                                car = new Car(s[2], int.Parse(s[3]));
                                people[j].AddInformation(car);
                                b = true;
                                break;
                            }                           
                        }
                    }
                    if(b == false)
                    {
                        if (s[1] == "pokemon" || s[1] == "parents" || s[1] == "children")
                        {
                            people.Add(new Person(s[0],s[1], s[2], s[3]));
                        }
                        if (s[1] == "company")
                        {
                            people.Add(new Person(s[0],s[2], s[3], float.Parse(s[4])));
                        }
                        if(s[1]== "car")
                        {
                            people.Add(new Person(s[0],s[2],int.Parse(s[3])));
                        }
                    }
                }
            }
            string a = Console.ReadLine();
            Console.WriteLine(" ");
            for (int i = 0; i < people.Count; i++)
            {
                if (a == people[i].Name)
                {
                    people[i].printOut();
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
