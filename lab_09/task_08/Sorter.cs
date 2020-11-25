using System;
using System.Collections.Generic;
using System.Text;

namespace task_08
{
    class Sorter<T>: Custom<T>
    {
        public void Sort()
        {
            for(int i = 0; i < List.Count; i++)
            {
                for(int j=0; j < List.Count; j++)
                {
                    if (Comparer<T>.Default.Compare(List[i], List[j]) < 0)
                    {
                        T tmp = List[i];
                        List[i] = List[j];
                        List[j] = tmp;
                    }
                }
            }
        }
    }
}
