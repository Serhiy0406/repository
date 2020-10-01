using System;
using System.Collections.Generic;
namespace task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Relationship> relationships = new List<Relationship>();
            string[] main = Console.ReadLine().Split(' ');
            for(int i = 0; i < 20; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (s[0] == "End")
                {
                    break;
                }
                else
                {
                    if (s[1] == "-")//check if will be work with '-'
                    {
                        if(s.Length==4)
                        {
                            relationships.Add(new Relationship(s[0], s[2] + " " + s[3]));
                        }
                        if (s.Length == 3)
                        {
                            relationships.Add(new Relationship(s[0], s[2]));
                        }
                    }
                    else if (s[2] == "-")
                    {
                        if (s.Length == 4)
                        {
                            relationships.Add(new Relationship( s[0] + " " + s[1], s[3]));
                        }
                        if (s.Length == 5)
                        {
                            relationships.Add(new Relationship(s[0] + " " + s[1], s[3] + " " + s[4]));
                        }
                    }
                    else
                    {
                        people.Add(new Person(s[0],s[1],s[2]));
                    }
                }
            }
            Console.WriteLine(" ");
            for(int i = 0; i < people.Count; i++)
            {
                if(main[0]==people[i].Name && main[1] == people[i].Surname || main[0]==people[i].Birthday)
                {
                    Console.WriteLine($"{people[i].Name} {people[i].Surname} {people[i].Birthday}");
                    Console.WriteLine("Parents:");
                    for (int j = 0; j< relationships.Count; j++)
                    {
                        if (relationships[j].Child == people[i].Name+" "+people[i].Surname || relationships[j].Child == people[i].Birthday)
                        {
                            for(int k = 0; k < people.Count; k++)
                            {
                                if(relationships[j].Parent== people[k].Name + " " + people[k].Surname || relationships[j].Parent == people[k].Birthday)
                                {
                                    Console.WriteLine($"{people[k].Name} {people[k].Surname} {people[k].Birthday}");
                                }
                            }
                        }
                    }
                    Console.WriteLine("Children:");
                    for (int j = 0; j < relationships.Count; j++)
                    {
                        if (relationships[j].Parent == people[i].Name + " " + people[i].Surname || relationships[j].Parent == people[i].Birthday)
                        {
                            for (int k = 0; k < people.Count; k++)
                            {
                                if (relationships[j].Child == people[k].Name + " " + people[k].Surname || relationships[j].Child == people[k].Birthday)
                                {
                                    Console.WriteLine($"{people[k].Name} {people[k].Surname} {people[k].Birthday}");
                                }
                            }
                        }
                    }
                    break;
                }
            }
            
            
            Console.ReadKey();
        }
    }
}
