using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimitiveCalculator primitiveCalculator = new PrimitiveCalculator();
            while (true)
            {
                string[] str = Console.ReadLine().Split(' ');
                if (str[0] == "End") { break; }
                else if (str[0] == "mode")
                {
                    primitiveCalculator.ChangeStrategy(char.Parse(str[1]));
                }
                else
                {
                    primitiveCalculator.Calculation -= PrimitiveCalculator_Calculation;
                    primitiveCalculator.Calculation += PrimitiveCalculator_Calculation;
                    
                    primitiveCalculator.PerformCalculation(int.Parse(str[0]), int.Parse(str[1]));
                }
            }
            Console.ReadKey();
        }

        private static void PrimitiveCalculator_Calculation(object sender, PrimitiveCalculatorEventArgs e)
        {
            if (e.Operation == '+') { Console.WriteLine(e.Number1 + e.Number2); }
            else if (e.Operation == '-') { Console.WriteLine(e.Number1 - e.Number2); }
            else if (e.Operation == '*') { Console.WriteLine(e.Number1 * e.Number2); }
            else { Console.WriteLine(e.Number1 / e.Number2); }
        }
    }
}
