using System;
using System.Collections.Generic;
using System.Text;

namespace task_5
{
    class Topping
    {
        private float weight;
        private string type;
        public float Calories { get => CalculateCalories(); }
        public float Weight
        {
            get { return weight; }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new Exception($"{type} weight should be in the range [1..50].");
                }
                else
                {
                    weight = value;
                }
            }
        }
        public string Type
        {
            get { return type; }
            set
            {
                if (value != "Meat" && value != "Veggies" && value != "Cheese" && value != "Sauce")
                {
                    throw new Exception($"Cannot place {value} on top of your pizza.");
                }
                else
                {
                    type = value;
                }
            }
        }
        public Topping(float w, string ty)
        {
            Type = ty;
            Weight = w; 
        }
        private float CalculateCalories()
        {
            float x, result;
            if (type == "Meat")
            {
                x = 1.2F;
            }
            else if(type == "Veggies")
            {
                x = 0.8F;
            }
            else if (type == "Cheese")
            {
                x = 1.1F;
            }
            else if (type == "Sauce")
            {
                x = 0.9F;
            }
            else
            {
                x = 0;
            }
            result = weight * 2 * x;
            return result;
        }
    }
}
