using System;
using System.Collections.Generic;
using System.Text;

namespace task_09
{
    class Collection1:IAddCollection
    {
        public List<string> list = new List<string>();
        public virtual int Add(string item)
        {
            list.Add(item);
            return list.IndexOf(item);
        }
    }
}
