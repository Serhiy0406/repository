using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    class Car: Mashine
    {
        public Car(string model, int speed, int power, int weight, string type, double pressure1, int age1, double pressure2, int age2, double pressure3, int age3, double pressure4, int age4)
            : base (model,speed,power,weight,type,pressure1,age1,pressure2,age2, pressure3, age3, pressure4, age4)
        {
        }
        public override void Check(string type)
        {
            if(CArgo.Type == "fragile" && type == "fragile")
            {
                for(int i = 0; i < 4; i++)
                {
                    if (TIre[i].Pressure < 1)
                    {
                        Console.WriteLine($"{Model}");
                        break;
                    }
                }
            }
            if (CArgo.Type == "flamable" && type == "flamable" && ENgine.Power>250)
            {
                Console.WriteLine($"{Model}");
            }
        }
    }
}
