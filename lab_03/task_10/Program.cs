using System;

namespace task_10
{
    class Program
    {
        class Engine 
        {
            public string model;
            public int power;
            public int displacement;
            public string efficiency;

            static public Engine Check(string s, int n, Engine []engine)
            {
                for(int i = 0; i < n; i++)
                {
                    if (engine[i].model == s)
                    {
                        return engine[i];
                    }
                }
                return null;
            }
            public Engine(string model, int power, int displacement, string efficiency)
            {
                this.model = model;
                this.power = power;
                this.displacement = displacement;
                this.efficiency = efficiency;
            }
            public Engine(string model, int power)
            {
                this.model = model;
                this.power = power;
                displacement = 0;
                efficiency = "n/a";
            }
            public Engine(string model, int power, int displacement)
            {
                this.model = model;
                this.power = power;
                this.displacement = displacement;
                efficiency = "n/a";
            }
            public Engine(string model, int power, string efficiency)
            {
                this.model = model;
                this.power = power;
                displacement = 0;
                this.efficiency = efficiency;
            }
        }

        class Car
        {
            string model;
            Engine c;
            int weight;
            string color;
            public Car(string model, string s, int weight, string color, int n ,Engine[] engine)
            {
                this.model = model;
                c = Engine.Check(s,n,engine);
                this.weight = weight;
                this.color = color;
            }
            public Car(string model, string s, int n, Engine[] engine)
            {
                this.model = model;
                c = Engine.Check(s, n, engine);
                weight = 0;
                color = "n/a";
            }
            public Car(string model, string s, int weight, int n, Engine[] engine)
            {
                this.model = model;
                c = Engine.Check(s, n, engine);
                this.weight = weight;
                color = "n/a";
            }
            public Car(string model, string s, string color, int n, Engine[] engine)
            {
                this.model = model;
                c = Engine.Check(s, n, engine);
                weight = 0;
                this.color = color;
            }
            static public void  Output(Car[] car, int m)
            {
                for(int i = 0; i < m; i++)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine($"{car[i].model}:");
                    Console.WriteLine($"  {car[i].c.model}:");
                    Console.WriteLine($"     Power: {car[i].c.power}");
                    if (car[i].c.displacement == 0)
                    {
                        Console.WriteLine($"     Displacement: n/a");
                    }else
                    Console.WriteLine($"     Displacement: {car[i].c.displacement}");
                    Console.WriteLine($"     Efficiency: {car[i].c.efficiency}");
                    if (car[i].weight == 0)
                    {
                        Console.WriteLine($"  Weight: n/a");
                    }else
                        Console.WriteLine($"  Weight: {car[i].weight}");
                    Console.WriteLine($"  Color: {car[i].color}");
                }
            }
        }
        static void Main(string[] args)
        {
            
            int n = Convert.ToInt32(Console.ReadLine());
            Engine[] engine = new Engine[n];
            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (s.Length == 4) { engine[i] = new Engine(s[0],Convert.ToInt32(s[1]), Convert.ToInt32(s[2]),s[3]);}
                if (s.Length == 2) { engine[i] = new Engine(s[0], Convert.ToInt32(s[1])); }
                if (s.Length == 3 && s[2][0] < 'A') { engine[i] = new Engine(s[0], Convert.ToInt32(s[1]), Convert.ToInt32(s[2])); }
                if (s.Length == 3 && s[2][0] >= 'A') { engine[i] = new Engine(s[0], Convert.ToInt32(s[1]), s[2]); }
            }
            int m = Convert.ToInt32(Console.ReadLine());
            Car[] car = new Car[m];
            for(int i = 0; i < m; i++)
            {
                string[] k = Console.ReadLine().Split(' ');
                if (k.Length == 4) { car[i] = new Car(k[0], k[1], Convert.ToInt32(k[2]), k[3], n, engine); }
                if (k.Length == 2) { car[i] = new Car(k[0], k[1], n, engine); }
                if (k.Length == 3 && k[2][0] >= 'A') { car[i] = new Car(k[0], k[1], k[2], n, engine); }
                if (k.Length == 3 && k[2][0] < 'A') { car[i] = new Car(k[0], k[1], Convert.ToInt32(k[2]), n, engine); }
                
            }
            Car.Output(car, m);
            Console.ReadKey();
        }
    }
}
