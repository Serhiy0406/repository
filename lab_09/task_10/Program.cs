using System;
using System.Collections.Generic;
namespace task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line1 = Console.ReadLine().Split(' ');
            Tuple<string, string> tuple1 = new Tuple<string, string>(line1[0] + " " + line1[1], line1[2]);
            string[] line2 = Console.ReadLine().Split(' ');
            Tuple<string, int> tuple2 = new Tuple<string, int>(line2[0], int.Parse(line2[1]));
            string[] line3 = Console.ReadLine().Split(' ');
            Tuple<int, double> tuple3 = new Tuple<int, double>(int.Parse(line3[0]), double.Parse(line3[1]));

            Console.WriteLine("{0} -> {1}", tuple1.Item1, tuple1.Item2);
            Console.WriteLine("{0} -> {1}", tuple2.Item1, tuple2.Item2);
            Console.WriteLine("{0} -> {1}", tuple3.Item1, tuple3.Item2);

            Console.ReadKey();
        }
    }
}
