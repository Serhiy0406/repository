using System;
using System.Collections.Generic;
using System.Text;

namespace task_12
{
    class Person
    {
        private string name;
        private List<Company> companies = new List<Company>();
        private List<Pokemon> pokemons = new List<Pokemon>();
        private List<Parents> parents = new List<Parents>();
        private List<Children> childrens = new List<Children>();
        private List<Car> cars = new List<Car>();
        public string Name { get; set; }
        public List<Company> Com { get; set; }
        public List<Pokemon> Pok { get; set; }
        public List<Parents> Par { get; set; }
        public List<Children> Chi { get; set; }
        public List<Car> Ca { get; set; }

        public Person(string namePer , string word, string name , string other )
        {
            Com = new List<Company>();
            Ca = new List<Car>();
            Par = new List<Parents>();
            Pok = new List<Pokemon>();
            Chi = new List<Children>();
            Name = namePer;
            if (word == "pokemon")
            {            
                Pok.Add(new Pokemon(name, other));
            }
            if (word == "parents")
            {
                
                Par.Add(new Parents(name, other));
            }
            if (word == "children")
            {
                
                Chi.Add(new Children(name, other));
            }
        }
        public Person(string namePer,string name , string department, float salary)
        {
            Com = new List<Company>();
            Ca = new List<Car>();
            Par = new List<Parents>();
            Pok = new List<Pokemon>();
            Chi = new List<Children>();
            Name = namePer;
            Com.Add(new Company(name , department, salary));
        }
        public Person(string namePer,string model, int speed)
        {
            Com = new List<Company>();
            Ca = new List<Car>();
            Par = new List<Parents>();
            Pok = new List<Pokemon>();
            Chi = new List<Children>();
            Name = namePer;
            Ca.Add(new Car(model, speed));
        }
        public void AddInformation(Company company)
        {
            
            Com.Add(company);
            if (Com.Count > 0)
            {
                Com.RemoveAt(0);
            }      
        }
        public void AddInformation(Car car)
        {
            
            Ca.Add(car);
            if (Ca.Count > 0)
            {
                Ca.RemoveAt(0);
            }
            
        }
        public void AddInformation(Pokemon pokemon)
        {
            
            Pok.Add(pokemon);
        }
        public void AddInformation(Parents parents)
        {
            
            Par.Add(parents);
        }
        public void AddInformation(Children children)
        {
            
            Chi.Add(children);
        }
        public void printOut()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"Company:");
            if (Com.Count > 0)
            {
                Console.WriteLine($"{Com[0].Name} {Com[0].Department} {Com[0].Salary}");
            }  
            Console.WriteLine($"Car:");
            if (Ca.Count > 0)
            {
                Console.WriteLine($"{Ca[0].Model} {Ca[0].Speed}");
            }
            Console.WriteLine($"Pokemon:");
            for(int i = 0; i < Pok.Count; i++)
            {
                Console.WriteLine($"{Pok[i].Name} {Pok[i].Type}");
            }
            Console.WriteLine($"Parents:");
            for (int i = 0; i < Par.Count; i++)
            {
                Console.WriteLine($"{Par[i].Name} {Par[i].Birthday}");
            }
            Console.WriteLine($"Children:");
            for (int i = 0; i < Chi.Count; i++)
            {
                Console.WriteLine($"{Chi[i].Name} {Chi[i].Birthday}");
            }
        }
    }
}
