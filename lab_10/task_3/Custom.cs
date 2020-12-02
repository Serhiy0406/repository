using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace task_3
{
    class Custom<T>:IEnumerable<T>
    {
        public List<T> LIst { get; set; } = new List<T>();
        public void Push(List<T> array)
        {
            foreach (var i in array)
                LIst.Add(i);
        }
        public void Pop()
        {
            if (LIst.Count == 0) { throw new Exception("No elements"); }
            else { LIst.RemoveAt(LIst.Count - 1);}     
        }
        public IEnumerator<T> GetEnumerator()
        {
            for(int i = LIst.Count - 1; i >= 0; i--)
            {
                yield return LIst[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return LIst.GetEnumerator();
        }
    }
}
