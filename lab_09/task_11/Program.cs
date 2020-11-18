using System;

namespace task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line1 = Console.ReadLine().Split(' ');
            Threeuple<string, string, string> threeuple1 = new Threeuple<string, string, string>(line1[0] + " " + line1[1], line1[2], line1[3]);
            string[] line2 = Console.ReadLine().Split(' ');          
            Threeuple<string, int, string> threeuple2 = new Threeuple<string, int, string>(line2[0], int.Parse(line2[1]), line2[2]);          
            string[] line3 = Console.ReadLine().Split(' ');
            Threeuple<string, double, string> threeuple3 = new Threeuple<string, double, string>(line3[0], double.Parse(line3[1]), line3[2]);

            Console.WriteLine("{0} -> {1} -> {2}", threeuple1.Item1, threeuple1.Item2, threeuple1.Item3);   
            if(threeuple2.Item3 == "drunk")
            {
                Console.WriteLine("{0} -> {1} -> {2}", threeuple2.Item1, threeuple2.Item2, true);
            }
            else { Console.WriteLine("{0} -> {1} -> {2}", threeuple2.Item1, threeuple2.Item2, false); }
            Console.WriteLine("{0} -> {1} -> {2}", threeuple3.Item1, threeuple3.Item2, threeuple3.Item3);

            Console.ReadKey();
        }
    }
}
