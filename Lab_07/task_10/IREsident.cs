using System;
using System.Collections.Generic;
using System.Text;

namespace task_10
{
    interface IREsident
    {
        string Name { get; set; }
        string Country { get; set; }
        string GetName();
    }
}
