using System;

namespace task_08
{
    class Program
    {
        class Engine 
        {
            public int speed, power;
        }
        class Cargo 
        {
            public int weight;
            public string type;
        }
        class Tire
        {
            public int age;
            public double pressure;
        }
        public class Car
        {
            string model;
            Engine engine;
            Cargo cargo;
            Tire[] tire=new Tire[4];

            public Car(string model,int speed, int power, int weight, string type, double pressure0, int age0, double pressure1, int age1, double pressure2, int age2, double pressure3, int age3)
            {
                this.model = model;
                engine = new Engine();
                engine.speed = speed;
                engine.power = power;
                cargo = new Cargo();
                cargo.weight = weight;
                cargo.type = type;
                tire[0] = new Tire();
                tire[0].age = age0;
                tire[0].pressure = pressure0;
                tire[1] = new Tire();
                tire[1].age = age1;
                tire[1].pressure = pressure1;
                tire[2] = new Tire();
                tire[2].age = age2;
                tire[2].pressure = pressure2;
                tire[3] = new Tire();
                tire[3].age = age3;
                tire[3].pressure = pressure3;
            }
            static public void Fragile(Car[] car, int n)
            {
                for(int i = 0; i < n; i++)
                {
                    if (car[i].cargo.type == "fragile")
                    {
                        for(int j = 0; j < 4; j++)
                        {
                            if (car[i].tire[j].pressure < 1)
                            {
                                Console.WriteLine($"{car[i].model}");
                                break;
                            }
                        }
                    }
                }
                
            }
            static public void Flamable(Car[] car, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    if (car[i].cargo.type == "flamable" && car[i].engine.power>250)
                    {
                        Console.WriteLine($"{car[i].model}");
                    }
                }

            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Car[] car = new Car[n];
            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                car[i] = new Car(s[0],Convert.ToInt32(s[1]), Convert.ToInt32(s[2]), Convert.ToInt32(s[3]), s[4], Convert.ToDouble(s[5]), Convert.ToInt32(s[6]), Convert.ToDouble(s[7]), Convert.ToInt32(s[8]), Convert.ToDouble(s[9]), Convert.ToInt32(s[10]), Convert.ToDouble(s[11]), Convert.ToInt32(s[12]));
            }
            string r = Console.ReadLine();
            if(r == "fragile")
            {
                Car.Fragile(car, n);
            }
            else
            {
                Car.Flamable(car, n);
            }
            Console.ReadKey();
        }
    }
}
