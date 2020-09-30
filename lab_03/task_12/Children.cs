using System;
using System.Collections.Generic;
using System.Text;

namespace task_12
{
    class Children
    {
        private string name;
        private string birthday;
        public string Name { get; set; }
        public string Birthday { get; set; }
        public Children(string name, string birthday)
        {
            Name = name;
            Birthday = birthday;
        }
    }
}
