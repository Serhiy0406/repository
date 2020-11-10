using System;
using System.Collections.Generic;
using System.Text;

namespace task_09
{
    interface IMyList:IAddRemoveCollection
    {
        public int Used { get; }
    }
}
