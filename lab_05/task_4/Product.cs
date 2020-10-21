using System;
using System.Collections.Generic;
using System.Text;

namespace task_4
{
    class Product
    {
        private string name;
        private int cost;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null || value == "")
                {
                    throw new Exception("Name cannot be empty");
                }
                else
                {
                    name = value;
                }
            }
        }
        public int Cost
        {
            get { return cost; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }
                else
                {
                    cost = value;
                }
            }
        }
        public Product(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
