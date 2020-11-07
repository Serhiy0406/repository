using System;
using System.Linq;

namespace task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] numbers = Console.ReadLine().Split(' ');
            string[] sites = Console.ReadLine().Split(' ');
            Phone phone = new Phone();
            foreach (var i in numbers)
            {
                phone.Call(i);
            }
            
            foreach(var i in sites)
            {
                try
                {
                    for(int y = 0; y < i.Length; y++)
                    {
                        if (Char.IsDigit(i[y]))
                        {
                            throw new Exception("Invalid URL!");
                        }
                    }
                    phone.Surf(i);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
