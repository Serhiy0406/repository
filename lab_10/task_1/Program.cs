using System;
using System.Collections.Generic;
using System.Linq;
namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ListyIterator<string> a;
                List<string> b = new List<string>();
                string[] str = Console.ReadLine().Split(' ');
                foreach (var i in str)
                    b.Add(i);
                b.Remove("Create");
                if (str.Length > 1)
                {
                    a = new ListyIterator<string>(b);
                }else if (str[0] != "Create"){  throw new Exception("First command should be Create");}
                else
                {
                    a = new ListyIterator<string>();
                }
                int count = 1;
                do
                {
                    count++;
                    if (count > 100) { throw new Exception("Comands should have 100 max inputs"); }
                    str = Console.ReadLine().Split(' ');
                    string switchcase = str[0];
                    switch (switchcase)
                    {
                        case "END":
                            break;
                        case "Create":
                            throw new Exception("Create oparation should be only once a time!!!");
                        case "Move":
                            Console.WriteLine(a.Move());                      
                            break;
                        case "HasNext":
                            Console.WriteLine(a.HasNext());
                            break;
                        case "Print":
                            a.Print();
                            break;
                    }
                } while (str[0] != "End");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            
            Console.ReadKey();
        }
    }
}
