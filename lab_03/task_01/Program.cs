using System;

namespace task_01
{
    class Person 
    {
        string name;
        int age;
        public string Name { get; set; }
        public int Age { get; set; }
        public Person (string name , int age)
        {
            Name = name;
            Age = age;
        }
        public Person()
        {
            Name = "Gosho";
            Age = 18;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person("Pesho", 20);
            Person c = new Person();
            Person b = new Person();
            b.Name = Console.ReadLine();
            b.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a.Name}-{a.Age}");
            Console.WriteLine($"{b.Name}-{b.Age}");
            Console.WriteLine($"{c.Name}-{c.Age}");

            Console.ReadKey();
        }
    }
}
