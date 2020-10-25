using System;
using System.Collections.Generic;
using System.Text;

namespace task_5
{
    class Dough
    {
        private float weight;
        private string type;
        private string technique;
        public float Calories { get => CalculateCalories(); }
        public float Weight
        {
            get { return weight; }
            set
            {
                if(value < 1 || value > 200)
                {
                    throw new Exception("Dough weight should be in the range [1..200].");
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
                if(value != "White" && value != "Wholegrain")
                {
                    throw new Exception("Invalid type of dough.");
                }
                else
                {
                    type = value;
                }
            }
        }
        public string Technique
        {
            get { return technique; }
            set
            {
                if (value != "Crispy" && value != "Chewy" && value != "Homemade")
                {
                    throw new Exception("Invalid type of dough.");
                }
                else
                {
                    technique = value;
                }
            }
        }
        public Dough(float w, string ty, string te)
        {
            Weight = w;
            Type = ty;
            Technique = te;
        }
        private float CalculateCalories()
        {
            float x, y,result;
            if (type == "White")
            {
                x=1.5F;
            }
            else
            {
                x = 1.0F;
            }
            if (technique == "Crispy")
            {
                y = 0.9F;
            }
            else if(technique == "Chewy")
            {
                y = 1.1F;
            }
            else
            {
                y = 1.0F;
            }
            result = weight * 2 * x * y;
            return result;
        }
    }
}
