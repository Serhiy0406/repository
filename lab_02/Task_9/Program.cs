using System;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alp = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            Console.Write("Input word : ");
            string arr = Console.ReadLine();
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < 26; j++)
                {
                    if (arr[i] == alp[j])
                    {
                        Console.WriteLine($"{alp[j]} => {j}");
                    }
                }
                
            }
            Console.ReadKey();
        }
    }
}
