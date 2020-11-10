using System;
using System.Collections.Generic;
using System.Text;

namespace task_09
{
    interface IAddRemoveCollection:IAddCollection
    {
        public string Remove();
    }
}
