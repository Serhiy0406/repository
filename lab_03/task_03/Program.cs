using System;

namespace task_03
{
    class Person
    {
        string name;
        int age;
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Family
    {
        Person[] x;
        private int size=0;
        public Family(int n)
        {
            x = new Person[n];
        }

        public void AddMember(Person member)
        {
            x[size] = member;
            size++;
        }
        public Person GetOldest()
        {
            int max = -1;
            int max_i = 0;
            for(int i = 0; i < size; i++)
            {
                if (max < x[i].Age)
                {
                    max = x[i].Age;
                    max_i = i;
                }
            }
            return x[max_i];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Family family = new Family(n);
            for(int i = 0; i < n; i++)
            {
                string []s = Console.ReadLine().Split(' ');
                Person tmp = new Person();
                tmp.Name = s[0];
                tmp.Age = Convert.ToInt32(s[1]);
                family.AddMember(tmp);
            }
            Console.WriteLine($"{family.GetOldest().Name} {family.GetOldest().Age}");
            Console.ReadKey();
        }
    }
}
