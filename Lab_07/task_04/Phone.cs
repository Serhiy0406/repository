using System;
using System.Collections.Generic;
using System.Text;

namespace task_04
{
    class Phone:ICalling, ISurfing
    {
        private const string model = "smarthone";
        public string Model { get { return model; } }
        public void Call(string number)
        {
            Console.WriteLine($"Calling... {number}");
        }
        public void Surf(string site)
        {
            Console.WriteLine($"Browsing: {site}");
        }
    }
}
