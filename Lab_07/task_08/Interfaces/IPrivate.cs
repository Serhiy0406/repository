using System;
using System.Collections.Generic;
using System.Text;

namespace task_08.Interfaces
{
    interface IPrivate: ISoldier
    {
        public float Salary { get; set; }
    }
}
