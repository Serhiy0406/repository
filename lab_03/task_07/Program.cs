using System;

namespace task_07
{
    class Program
    {
        class Car
        {
            string model;
            double fuelCon;
            double fuelAm;
            int distance;
            public Car(string model, double fuelAm, double fuelCon)
            {
                this.model = model;
                this.fuelAm = fuelAm;
                this.fuelCon = fuelCon;
                this.distance = 0;
            }
            static public void Check(string Model, int Distance, Car[] car , int n)
            {
                for(int i = 0; i < n; i++)
                {
                    if (car[i].model == Model)
                    {
                        if (car[i].fuelAm / car[i].fuelCon>Distance)
                        {
                            car[i].distance += Distance;
                            car[i].fuelAm -= car[i].fuelCon * Distance;
                        }
                        else
                        {
                            Console.WriteLine("Insufficient fuel for the drive");
                        }
                    }
                }
            }
            static public void Output(Car [] car ,int n)
            {
                for(int i = 0; i < n; i++)
                {
                    Console.WriteLine($"{car[i].model} {car[i].fuelAm:0.00} {car[i].distance}");
                }
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a;
            Car[] car = new Car[n];
            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                car[i] = new Car(s[0],Convert.ToDouble(s[1]),Convert.ToDouble(s[2]));
            }
            for(int k=0;k<100;k++)
            {
                 a = Console.ReadLine().Split(' ');
                if (a[0] == "Drive")
                {
                    Car.Check(a[1],Convert.ToInt32(a[2]), car, n);
                }
                if (a[0] == "End")
                {
                    Car.Output(car, n);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
