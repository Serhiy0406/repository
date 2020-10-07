using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    abstract class Mashine
    {
        public string Model { get; set; }
        public Cargo CArgo { get; set; }
        public Engine ENgine { get; set; }
        public List<Tire> TIre = new List<Tire>();
        public Mashine(string model, int speed , int power, int weight, string type, double pressure1, int age1, double pressure2, int age2, double pressure3, int age3, double pressure4, int age4) 
        {
            Model = model;
            ENgine = new Engine();
            ENgine.Speed = speed;
            ENgine.Power = power;
            CArgo = new Cargo();
            CArgo.Weight = weight;
            CArgo.Type = type;
            TIre.Add(new Tire(pressure1,age1));
            TIre.Add(new Tire(pressure2, age2));
            TIre.Add(new Tire(pressure3, age3));
            TIre.Add(new Tire(pressure4, age4));
        }
        public abstract void Check(string type);
    }
}
