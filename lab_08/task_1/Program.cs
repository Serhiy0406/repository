using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation mo = new MathOperation();
            Console.WriteLine(mo.Add(2, 3));
            Console.WriteLine(mo.Add(2.2, 3.3, 5.5));
            Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));

            Console.ReadKey();
        }
    }
}
