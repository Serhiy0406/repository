using System;
using System.Collections.Generic;
using System.Text;

namespace task_12
{
    class Parents
    {
        private string name;
        private string birthday;
        public string Name { get; set; }
        public string Birthday { get; set; }
        public Parents(string name, string birthday)
        {
            Name = name;
            Birthday = birthday;
        }
    }
}
