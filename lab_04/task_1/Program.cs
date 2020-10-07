using System;
using System.Collections.Generic;
namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> car = new List<Car>();
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                car.Add(new Car(s[0],Convert.ToInt32(s[1]), Convert.ToInt32(s[2]), Convert.ToInt32(s[3]), s[4], double.Parse(s[5]), int.Parse(s[6]), double.Parse(s[7]),int.Parse(s[8]), double.Parse(s[9]), int.Parse(s[10]), double.Parse(s[11]),int.Parse(s[12])));
            }
            string s1 = Console.ReadLine();
            for(int i = 0; i < car.Count; i++)
            {
                car[i].Check(s1);
            }
            Console.ReadKey();
        }
    }
}
