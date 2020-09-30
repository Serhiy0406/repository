using System;
using System.Collections.Generic;
using System.Text;

namespace task_12
{
    class Pokemon
    {
        private string name;
        private string type;
        public string Name { get; set; }
        public string Type { get; set; }
        public Pokemon(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
