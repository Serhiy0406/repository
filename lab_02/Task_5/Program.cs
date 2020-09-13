using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b =true;
            char[] a1 = new char[10];
            char[] a2 = new char[10];
            Console.Write("Input size of first array : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input size of second array : ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Array1 : ");
            for(int i = 0; i < n1; i++)
            {
                a1[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Array2 : ");
            for (int i = 0; i < n2; i++)
            {
                a2[i] = Convert.ToChar(Console.ReadLine());
            }

            for(int i = 0; i < n1; i++)
            {
                for(int j = 0; j < n2; j++)
                {     
                    if (a1[i] == a2[j])
                    {
                        if (i == n1 - 1 || j == n2 - 1) 
                        { 
                            if(n1 < n2) { b = true; }
                            else { b = false; }
                            break; 
                        }
                        else { i++; }
                    }
                    else
                    {
                        if (a1[i] < a2[j]) { b = true; }
                        else { b = false; }
                    }          
                }
                break;
            }
            if (b == true)
            {
                for (int i = 0; i < n1; i++)
                {
                    Console.Write(a1[i]);
                }
                Console.WriteLine(" ");
                for (int i = 0; i < n2; i++)
                {
                    Console.Write(a2[i]);
                }
            }
            else
            {
                for (int i = 0; i < n2; i++)
                {
                    Console.Write(a2[i]);
                }
                Console.WriteLine(" ");
                for (int i = 0; i < n1; i++)
                {
                    Console.Write(a1[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
