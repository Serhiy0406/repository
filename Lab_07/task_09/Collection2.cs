using System;
using System.Collections.Generic;
using System.Text;

namespace task_09
{
    class Collection2: Collection1, IAddRemoveCollection 
    {
        public override int Add(string item)
        {
            list.Insert(0, item);
            return list.IndexOf(item);
        }
        public virtual string Remove()
        {
            string result =  list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return result;
        }
    }
}
