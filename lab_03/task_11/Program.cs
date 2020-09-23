using System;

namespace task_11
{
    class Program
    {
        class Pokemon 
        {
            public string name;
            public string element;
            public int health;
            public Pokemon(string name, string element,int health)
            {
                this.name = name;
                this.element = element;
                this.health = health;
            }
        }

        class Trainer 
        {
            string name;
            int badge;
            static int l = 0;
            Pokemon[] pokemon;
           
            public Trainer(string name,Pokemon pokemon)
            {
                badge = 0;
                this.name = name;
                this.pokemon[l] = pokemon;
                l++;
            }
            public static bool Check(Trainer[] trainer , int n, string s)
            {
                for(int i = 0; i < n; i++)
                {
                    if (trainer[i].name == s) { return true; }
                }
                return false;
            }
            public static void Add(Pokemon pokemon, string name , int n , Trainer[] trainer)
            {
                for(int i = 0; i < n; i++)
                {
                    if (trainer[i].name == name)
                    {
                        trainer[i].pokemon[l] = pokemon;
                        l++;
                    }
                }
            }
            public static void CheckPokemon(string element, int m,int n , Trainer[] trainer )
            {
                for(int i = 0; i < n; i++)
                {
                    for(int j = 0; j < m; j++)
                    {
                        if (trainer[i].pokemon[j].element == element)
                        {
                            //зробити додавання до оцінки і брейк
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int n = 1;
            int m = 1;
            Pokemon[] pokemon = new Pokemon[m];
            Trainer[] trainer = new Trainer[n];
            for(int i = 0; i < 100; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (s[0] == "Tournament") { break; }
                else
                {
                    m++;
                    pokemon[i] = new Pokemon(s[1], s[2], Convert.ToInt32(s[3]));
                    if(true == Trainer.Check(trainer, n, s[0]))
                    {
                        Trainer.Add(pokemon[i],s[0],n,trainer);
                    }
                    else
                    {
                        trainer[i] = new Trainer(s[0], pokemon[i]);
                    }
                }       
            }
            for(int i = 0; i < 100; i++)
            {
                string p=Console.ReadLine();
                if (p == "End") { break; }
                else
                {
                    Trainer.CheckPokemon(p, m, n, trainer);
                }
            }
            Console.ReadKey();
        }
    }
}
