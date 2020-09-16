using System;
using System.Drawing;

namespace task_04
{
    class Program
    {
        class Person
        {
            string name;
            int age;
            public string Name { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Person[] x = new Person[n];
 
            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                x[i] = new Person();
                x[i].Name = s[0];
                x[i].Age = Convert.ToInt32(s[1]);
            }

            for(int i = 0; i < n; i++)
            {
                for(int j = i+1; j < n; j++)
                {
                    int k = 0;
                    while(x[i].Name[k] == x[j].Name[k] && k<x[i].Name.Length-1 && k < x[i].Name.Length-1)
                    {
                        k++;
                    }
                    if (x[i].Name[k] < x[j].Name[k])
                    {
                        Person tmp = new Person();
                        tmp = x[j];
                        x[j] = x[i];
                        x[i] = tmp;
                    }
                }
            }

            for(int i = 0; i < n; i++)
            {
                if (x[i].Age > 30)
                {
                    Console.WriteLine($"{x[i].Name} - {x[i].Age}");
                }
            }
            
            Console.ReadKey();
        }
    }
}
