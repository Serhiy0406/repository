using System;
using System.Collections.Generic;
using System.Text;

namespace task_12
{
    class Company
    {
        private string name;
        private string product;
        private int amount;
        public string Name
        {
            get { return name; }
            set
            {
                if(value.Length>=1 && value.Length <= 20)
                {
                    name = value;
                }
                else { throw new Exception("Length of company name should be between [1 .. 20]"); }
            }
        }
        public string Product
        {
            get { return product; }
            set
            {
                if (value.Length >= 1 && value.Length <= 20)
                {
                    product = value;
                }
                else { throw new Exception("Length of product name should be between [1 .. 20]"); }
            }
        }
        public int Amount
        {
            get { return amount; }
            set
            {
                if(value>=1 && value <= 1000)
                {
                    amount = value;
                }
                else { throw new Exception("Value of amount should be between [1 .. 1000]"); }
            }
        }
        public Company(string name, int amount ,string product)
        {
            Name = name;
            Amount = amount;
            Product = product;
        }
    }
}
