using System;
using System.Collections.Generic;
using task_6.AimalClasses;
using task_6.catClasses;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Animal> animals = new List<Animal>();
                string s1;
                do
                {
                    s1 = Console.ReadLine();
                    string[] s = Console.ReadLine().Split(' ');
                    switch(s1)
                    {
                        case "Cat":
                            if (s[2] == "Tomcats")
                            {
                                Tomcats tomcats = new Tomcats(s[0], int.Parse(s[1]), s[2]);
                                animals.Add(tomcats);
                            }
                            else if (s[2] == "Kitten")
                            {
                                Kitten kitten = new Kitten(s[0], int.Parse(s[1]), s[2]);
                                animals.Add(kitten);
                            }
                            else
                            {
                                Cat cat = new Cat(s[0], int.Parse(s[1]), s[2]);
                                animals.Add(cat);
                            }    
                            break;
                        case "Dog":
                            Dog dog = new Dog(s[0], int.Parse(s[1]), s[2]);
                            animals.Add(dog);
                            break;
                        case "Frog":
                            Frog frog = new Frog(s[0], int.Parse(s[1]), s[2]);
                            animals.Add(frog);
                            break;
                    }
                } while (s1!="Beast!");
                foreach (var i in animals)
                {
                    Type type = i.GetType();
                    Console.WriteLine(type);
                    Console.WriteLine(i);
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
