using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    public class NameChangeEventArgs: EventArgs
    {
        public string Name { get; private set; }

        public NameChangeEventArgs(string name)
        {
            Name = name;
        }
    }
}
