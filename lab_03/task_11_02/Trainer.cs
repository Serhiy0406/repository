using System;
using System.Collections.Generic;
using System.Text;

namespace task_11_02
{
    class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> Pokemonlist = new List<Pokemon>();
        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Pet { get; set; }

        public Trainer(string name, Pokemon pokemon)
        {
            Badges = 0;
            Name = name;
            Pet = new List<Pokemon>();
            Pet.Add(pokemon);
        }
        public void CheckPokemon(string element)
        {
            bool b = false;
            for (int i = 0; i < Pet.Count; i++)
            {
                if (Pet[i].Element == element)
                {
                    b = true;
                    Badges += 1;
                    break;
                }
            }
            if (b == false)
            {
                for(int i = 0; i < Pet.Count; i++)
                {
                    Pet[i].Health -= 10;
                }
                for (int i = 0; i < Pet.Count; i++)
                {
                    if (Pet[i].Health <= 0)
                    {
                        Pet.RemoveAt(i);
                        i--;
                    }
                }
            }
        }
        public static int CompareTrainers(Trainer user1, Trainer user2)
        {
            return user1.Badges.CompareTo(user2.Badges);
        }
        public void Add(Pokemon pokemon)
        {
            Pet.Add(pokemon);
        }
        public void printOut()
        {
            Console.WriteLine($"{Name} {Badges} {Pet.Count}");
        }
    }
}
