using System;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Linked_list<int> exp = new Linked_list<int>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                string Switchcase = str[0];
                switch(Switchcase){
                    case "Add":
                        exp.Add(int.Parse(str[1]));
                        break;
                    case "Remove":
                        exp.Remove(int.Parse(str[1]));
                        break;
                }                  
            }
            Console.WriteLine(exp.Count);
            foreach (var i in exp)
                Console.Write($"{i} ");
            Console.ReadKey();
        }
    }
}
