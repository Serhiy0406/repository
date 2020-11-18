using System;
using System.Collections.Generic;
using System.Text;

namespace task_08
{
    class Sorter<T>: Custom<T>
    {
        public void Sort()
        {
/*            List<T> list2 = new List<T>();
            list2 = List;
            foreach (var i in list2)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < list2.Count; i++)
            {
                if (i > 0 && list2[i-1]>Min())
                list2[i] = Min();
                List.Remove(Min());
            }
            foreach(var i in list2)
            {
                i = Min();

            }
            List= list2;*/
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
