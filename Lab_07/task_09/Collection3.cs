using System;
using System.Collections.Generic;
using System.Text;

namespace task_09
{
    class Collection3:Collection2, IMyList
    {
        public int Used
        {
            get { return list.Count; }
        }
        public override string Remove()
        {
            string result = list[0];
            list.RemoveAt(0);
            return result;
        }
    }
}
