using System;
using System.Collections.Generic;
using System.Text;

namespace task_10
{
    interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }
        string GetName();

    }
}
