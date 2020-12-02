using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace task_4
{
    class Lake:IEnumerable<int>
    {
        List<int> List { get; set; } = new List<int>();
        public Lake(List<int> elements) 
        {
            foreach (var i in elements)
                List.Add(i);
        }
        public IEnumerator<int> GetEnumerator()
        {
            List<int> evenN = new List<int>();
            List<int> oddN = new List<int>();
            for(int i = 0; i < List.Count; i++)
            {
                if ((i+1) % 2 != 0) { evenN.Add(List[i]); }
                else oddN.Add(List[i]);
            }
            oddN.Reverse();
            List.Clear();
            foreach (var i in evenN)
                List.Add(i);
            foreach (var i in oddN)
                List.Add(i);
            for (int i = 0; i < List.Count; i++)
            {
                yield return List[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return List.GetEnumerator();
        }
    }
}
