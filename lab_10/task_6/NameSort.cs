using System;
using System.Collections.Generic;
using System.Text;

namespace task_6
{
    class NameSort: IComparer<Person>
    {
        public int Compare(Person p1, Person p2)
        {
            return p1.Name.CompareTo(p2.Name);
        }
    }
}
