using System;
using System.Collections.Generic;
using System.Text;

namespace task_2
{
    class Final: Complection
    {
        public override void printOut()
        {
            for(int i = 0; i < cars.Count; i++)
            {
                for(int j = 0; j < engines.Count; j++)
                {
                    if(engines[j].Model == cars[i].Engine)
                    {
                        Console.WriteLine($"{cars[i].Model}");
                        Console.WriteLine($"  {cars[i].Engine}:");
                        Console.WriteLine($"    Power: {engines[j].Power}");
                        if(engines[j].Displacement==0)
                        Console.WriteLine($"    Displacement: n/a");
                        else
                        Console.WriteLine($"    Displacement: {engines[j].Displacement}");
                        Console.WriteLine($"    Efficiency: {engines[j].Efficiency}");
                        if(cars[i].Weight==0)
                        Console.WriteLine($"  Weight: n/a");
                        else
                        Console.WriteLine($"  Weight: {cars[i].Weight}");
                        Console.WriteLine($"  Color: {cars[i].Color}");
                    }
                }
            }
        }
    }
}
