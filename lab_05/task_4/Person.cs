using System;
using System.Collections.Generic;
using System.Text;

namespace task_4
{
    class Person
    {
        private string name;
        private int money;
        private List<Product> productslist = new List<Product>();
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
        public int Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }
                else
                {
                    money = value;
                }
            }
        }
        public Person (string name, int money)
        {
            Name = name;
            Money = money;
        }
        public void AddProduct(string name , int cost)
        {
            productslist.Add(new Product(name, cost));
        }
        public void Check(string name,int cost)
        {
            if (Money - cost >= 0)
            {
                productslist.Add(new Product(name,cost));
                Money -= cost;
                Console.WriteLine($"{Name} bought {name}");
            }
            else
            {
                Console.WriteLine($"{Name} can`t afford {name}");
            }
        }
        public void Output()
        {
            Console.Write($"{Name} - ");
            if (productslist.Count == 0)
            {
                Console.Write($"Nothing bought");
            }
            else
            {
                for (int i = 0; i < productslist.Count; i++)
                {
                    Console.Write($"{productslist[i].Name}, ");
                }
                Console.WriteLine("");
            } 
        }
    }
}
