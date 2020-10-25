using System;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] str = Console.ReadLine().Split(' ');
                Pizza pizza = new Pizza(str[1]);
                for (int i = 0; i < 30; i++)
                {
                    string[] s = Console.ReadLine().Split(' ');
                    if (s[0] == "END")
                    {
                        break;
                    }
                    else if(s[0]=="Dough")
                    {
                        pizza.AddDough(new Dough(float.Parse(s[3]), s[1], s[2]));
                    }
                    else
                    {
                        pizza.AddTopping(new Topping(float.Parse(s[2]), s[1]));
                    }
                }
                pizza.Output();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
