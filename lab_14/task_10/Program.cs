using System;

namespace task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string tmp;
            bool b = true;
            for (int j = 0; j < str.Length / 2; j++)
            {
                if (str[j] != str[str.Length - 1 - j])
                {
                    b = false;
                    break;
                }                  
            }
            if (b == true)
            {
                Console.WriteLine(-1);
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    tmp = str.Remove(i,1);
                    b = true;
                    for (int j = 0; j < tmp.Length / 2; j++)
                    {
                        if (tmp[j] != tmp[tmp.Length - 1 - j])
                        {
                            b = false;
                            break;
                        }
                    }
                    if (b == true)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
