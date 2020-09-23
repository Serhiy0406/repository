using System;

namespace task_11
{
    class Program
    {
        public class Pokemon 
        {
            private string name;
            private string element;
            private int health;

            public string Name { get => name; }
            public string Element { get => element; }
            public int  Health { get => health; set => health = value; }
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
            private Pokemon[] pokemon ;
            private int k = 0;
            public string Name { get => name; }
            public int Badge { get => badge; }
            public Pokemon[] Pet { get => pokemon; }

            public Trainer(string name,Pokemon pokemon)
            {
                badge = 0;
                this.name = name;
                this.pokemon= new Pokemon[20];
                this.pokemon[k] = pokemon;
                k++;
            }
            public void Add(Pokemon pokemon)
            {
                this.pokemon[k] = pokemon;
                k++;
            }

            public void Check(string s)
            {
                bool b = false;
                for (int i = 0; i < k; i++)
                {
                    b = false;
                    if (this.pokemon[i].Element == s)
                    {
                        this.badge += 1;
                        b = true;
                        break;
                    }
                }
                if (b == false)
                {
                    for(int i = 0; i < k; i++)
                    {
                        this.pokemon[i].Health -= 10;
                    }
                    for(int i = 0; i < k; i++)
                    {
                        if (this.pokemon[i].Health <= 0)
                        {
                            k--;//тут ще потрібно видалити сам елемент
                        }
                    }
                }
            }
            public void Output()
            {
                Console.WriteLine($"{this.name} {this.badge} {k} ");
            }
        }

        static void Main(string[] args)
        {
            int n = 0;
            int m = 0;
            Pokemon[] pokemon = new Pokemon[20];
            Trainer[] trainer = new Trainer[20];
            for (int i = 0; i < 100; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (s[0] == "Tournament") { break; }
                else
                {
                    pokemon[m] = new Pokemon(s[1], s[2], Convert.ToInt32(s[3]));
                    m++;
                    bool b = false;
                    for(int j = 0; j < n; j++)
                    {
                        if (trainer[j].Name == s[0])
                        {
                            trainer[j].Add(pokemon[i]);
                            b = true;
                        }
                    }
                    if (b == false)
                    {
                        trainer[n] = new Trainer(s[0], pokemon[i]);
                        n++;
                    }
                }
            }
            for (int i = 0; i < 100; i++)
            {
                string p = Console.ReadLine();
                if (p == "End") { break; }
                else
                {
                    for(int j = 0; j < n; j++)
                    {
                        trainer[j].Check(p);
                    }
                }
            }
            for(int i = 0; i < n; i++)
            {
                trainer[i].Output();
            }
            Console.ReadKey();
        }
    }
}
