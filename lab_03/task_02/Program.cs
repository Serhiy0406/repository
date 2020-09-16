using System;

namespace task_02
{
    class Person
    {
        string name;
        int age;
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Person(int age)
        {
            Name = "No name";
            Age = age;
        }
        public Person()
        {
            Age = 1;
            Name = "No name";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person();
            Person b = new Person(20);
            Person c = new Person("Thomas", 35);
            Console.WriteLine($"{a.Name}-{a.Age}");
            Console.WriteLine($"{b.Name}-{b.Age}");
            Console.WriteLine($"{c.Name}-{c.Age}");
            Console.ReadKey();
        }
    }
}
