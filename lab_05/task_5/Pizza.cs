using System;
using System.Collections.Generic;
using System.Text;

namespace task_5
{
    class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> listOfToppings = new List<Topping>();
        private float AllCalories=0;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null || value == "")
                {
                    throw new Exception("Pizza name cannot be empty");
                }
                else if (value.Length > 15)
                {
                    throw new Exception("Pizza name should be between 1 and 15 symbols.");
                }
                else
                {
                    name = value;
                }
            }
        }
        public void AddDough (Dough dough)
        {
            this.dough = dough;
            AllCalories += dough.Calories;
        }
        public void AddTopping(Topping topping)
        {
            listOfToppings.Add(topping);
            AllCalories += topping.Calories;
            if (listOfToppings.Count > 10)
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }
        }
        public void Output()
        {
            Console.WriteLine($"{Name} - {AllCalories:0.00} Calories.");
        }
        public Pizza(string name)
        {
            Name = name;
        }

    }
}
