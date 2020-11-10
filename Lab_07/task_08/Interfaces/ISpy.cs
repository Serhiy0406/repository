using System;
using System.Collections.Generic;
using System.Text;

namespace task_08.Interfaces
{
    interface ISpy: ISoldier
    {
        public int Codenumber { get; set; }
    }
}
