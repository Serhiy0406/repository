using System;
using System.Collections.Generic;
using System.Text;

namespace task_6
{
    class AgeSort:IComparer<Person>
    {
        public int Compare(Person p1, Person p2)
        {
            return p1.Age.CompareTo(p2.Age);
        }
    }
}
