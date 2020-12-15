using System;
using System.Text.RegularExpressions;

namespace task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string[] all = email.Split('@');
            string username = all[0];
            string domain = all[1];
            string saved = String.Empty;
            for(int i = 0; i < username.Length; i++)
            {
                saved += '*';
            }
            saved += '@' + domain;
            string info = Console.ReadLine();
            info = Regex.Replace(info, @$"\b{email}\b", saved);
            Console.WriteLine(info);
            Console.ReadKey();
        }
    }
}
