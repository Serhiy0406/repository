using System;
using System.Collections.Generic;
using System.Text;

namespace task_13
{
    class Relationship
    {
        public string Parent { get; set; }
        public string Child { get; set; }
        public Relationship(string parent , string child)
        {
            Parent = parent;
            Child = child;
        }
    }
}
