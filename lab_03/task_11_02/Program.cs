using System;
using System.Collections.Generic;
namespace task_11_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            Pokemon pokemons;
            bool b;
            for(int i = 0; i < 100; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (s[0] == "Tournament")
                {
                    break;
                }
                else
                {
                    pokemons=new Pokemon(s[1], s[2], Convert.ToInt32(s[3]));
                    b = false;
                    for (int j = 0; j < trainers.Count; j++)
                    {
                        if (trainers[j].Name == s[0])
                        {
                            trainers[j].Add(pokemons);
                            b = true;
                            break;
                        }
                    }
                    if (b == false)
                    {
                        trainers.Add(new Trainer(s[0], pokemons));
                    }
                }
            }
            for(int i = 0; i < 100; i++)
            {
                string s1 = Console.ReadLine();
                if (s1 == "End")
                {
                    break;
                }
                else
                {
                    for (int j = 0; j < trainers.Count; j++)
                    {
                        trainers[j].CheckPokemon(s1);
                    }
                }
            }

          //  trainers.Sort(Trainer.CompareTrainers);
            for(int i = 0; i < trainers.Count; i++)
            {
                trainers[i].printOut();
            }
            Console.ReadKey();
        }
    }
}
